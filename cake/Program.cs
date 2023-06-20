// Build
// Copyright (c) 2023 Peter Kurhajec (PTKu), MTS,  and Contributors. All Rights Reserved.
// Contributors: https://github.com/ix-ax/TIA2AX/graphs/contributors
// See the LICENSE file in the repository root for more information.
// https://github.com/ix-ax/TIA2AX/blob/master/LICENSE
// Third party licenses: https://github.com/ix-ax/TIA2AX/blob/master/notices.md

using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.IO.Compression;
using System.IO.Packaging;
using System.Linq;
using System.Management.Automation;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Build.FilteredSolution;
using Cake.Common;
using Cake.Common.IO;
using Cake.Common.Tools.DotNet;
using Cake.Common.Tools.DotNet.Clean;
using Cake.Common.Tools.DotNet.Restore;
using Cake.Core.Diagnostics;
using Cake.Core.IO;
using Cake.Core.Tooling;
using Cake.Frosting;
using Cake.Powershell;
using CliWrap;
using CommandLine;
using Microsoft.Extensions.DependencyInjection;
using NuGet.Packaging;
using Octokit;
using Polly;
using Spectre.Console;
using static System.Net.WebRequestMethods;
using Credentials = Octokit.Credentials;
using File = System.IO.File;
using Path = System.IO.Path;
using ProductHeaderValue = Octokit.ProductHeaderValue;


public static class Program
{
    public static int Main(string[] args)
    {
        var retVal = 0;
        Parser.Default.ParseArguments<BuildParameters>(args)
            .WithParsed<BuildParameters>(o =>
            {
                retVal = new CakeHost()
                    .ConfigureServices(services => services.AddSingleton(o))
                    .UseContext<BuildContext>()
                    .Run(args);
            });

        return retVal;
    }
}

[TaskName("CleanUp")]
public sealed class CleanUpTask : FrostingTask<BuildContext>
{
    public override void Run(BuildContext context)
    {
        context.DotNetClean(Path.Combine(context.RootDir, "tia2ax.sln"), new DotNetCleanSettings() { Verbosity = context.BuildParameters.Verbosity});
        context.CleanDirectory(context.Artifacts);
        context.CleanDirectory(context.TestResults);
        context.CleanDirectory(context.TestResultsCtrl);
    }
}

[TaskName("Build")]
[IsDependentOn(typeof(CleanUpTask))]
public sealed class BuildTask : FrostingTask<BuildContext>
{
    public override void Run(BuildContext context)
    {
        context.DotNetBuild(Path.Combine(context.RootDir, "tia2ax.sln"), context.DotNetBuildSettings);
    }
}

[TaskName("Test")]
[IsDependentOn(typeof(BuildTask))]
public sealed class TestsTask : FrostingTask<BuildContext>
{
    // Tasks can be asynchronous
    public override void Run(BuildContext context)
    {
        if (!context.BuildParameters.DoTest)
        {
            context.Log.Warning($"Skipping tests");
            return;
        }

        RunTestsFromFilteredSolution(context, Path.Combine(context.RootDir, "tia2axTests.slnf"));

        context.Log.Information("Tests done.");
    }

    private static void RunTestsFromFilteredSolution(BuildContext context, string filteredSolutionFile)
    {
        foreach (var project in FilteredSolution.Parse(filteredSolutionFile).solution.projects
                     .Select(p => new FileInfo(Path.Combine(context.RootDir, p)))
                     .Where(p => p.Name.ToUpperInvariant().Contains("TEST")))
        {
            foreach (var framework in context.TargetFrameworks)
            {
                context.DotNetTestSettings.VSTestReportPath = Path.Combine(context.TestResults, $"{project.Name}_{framework}.xml");
                context.DotNetTestSettings.Framework = framework;
                context.DotNetTest(Path.Combine(project.FullName), context.DotNetTestSettings);
            }
        }
    }
}

[TaskName("CreateArtifacts")]
[IsDependentOn(typeof(TestsTask))]
public sealed class CreateArtifactsTask : FrostingTask<BuildContext>
{
   

    public override void Run(BuildContext context)
    {
        if (!context.BuildParameters.DoPack)
        {
            context.Log.Warning($"Skipping packaging.");
            return;
        }

        PackNugets(context);
    }


    private static void PackNugets(BuildContext context)
    {
        context.DotNetPack(context.PackableNugetsSlnf, 
            new Cake.Common.Tools.DotNet.Pack.DotNetPackSettings()
        {
            OutputDirectory = Path.Combine(context.ArtifactsNugets),
            NoRestore = false,
            NoBuild = false,
        });
    }
}

[TaskName("GenerateApiDocumentation")]
[IsDependentOn(typeof(CreateArtifactsTask))]
public sealed class GenerateApiDocumentationTask : FrostingTask<BuildContext>
{
    public override void Run(BuildContext context)
    {
        if (!context.BuildParameters.DoDocs)
        {
            context.Log.Warning($"Skipping documentation generation.");
            return;
        }

        if (Helpers.CanReleaseInternal())
        {
           
        }
    }    
}


[TaskName("Check license compliance")]
[IsDependentOn(typeof(GenerateApiDocumentationTask))]
public sealed class LicenseComplianceCheckTask : FrostingTask<BuildContext>
{
    public override void Run(BuildContext context)
    {
        
    }
}


[TaskName("PushPackages task")]
[IsDependentOn(typeof(LicenseComplianceCheckTask))]
public sealed class PushPackages : FrostingTask<BuildContext>
{
    public override void Run(BuildContext context)
    {
        if (!context.BuildParameters.DoPublish)
        {
            context.Log.Warning($"Skipping package push.");
            return;
        }

        if (Helpers.CanReleaseInternal())
        {

            foreach (var nugetFile in Directory.EnumerateFiles(Path.Combine(context.Artifacts, @"nugets"), "*.nupkg")
                         .Select(p => new FileInfo(p)))
            {
                context.DotNetNuGetPush(nugetFile.FullName,
                    new Cake.Common.Tools.DotNet.NuGet.Push.DotNetNuGetPushSettings()
                    {
                        ApiKey = context.GitHubToken,
                        Source = "https://nuget.pkg.github.com/ix-ax/index.json",
                        SkipDuplicate = true
                    });
            }
        }
    }
}

[TaskName("Publish release")]
[IsDependentOn(typeof(PushPackages))]
public sealed class PublishReleaseTask : FrostingTask<BuildContext>
{
    public override void Run(BuildContext context)
    {
        if (!context.BuildParameters.DoPublishRelease)
        {
            context.Log.Warning($"Skipping package release.");
            return;
        }

        if (Helpers.CanReleaseInternal())
        {
            var githubToken = context.Environment.GetEnvironmentVariable("GH_TOKEN");
            var githubClient = new GitHubClient(new ProductHeaderValue("IX"));
            githubClient.Credentials = new Credentials(githubToken);

            var release = githubClient.Repository.Release.Create(
                "ix-ax",
                "TIA2AX",
                new NewRelease($"{GitVersionInformation.SemVer}")
                {
                    Name = $"{GitVersionInformation.SemVer}",
                    TargetCommitish = GitVersionInformation.Sha,
                    Body = $"Release v{GitVersionInformation.SemVer}",
                    Draft = !Helpers.CanReleasePublic(),
                    Prerelease = !string.IsNullOrEmpty(GitVersionInformation.PreReleaseTag)
                }
            ).Result;
        }
    }
}

[TaskName("Default")]
[IsDependentOn(typeof(PublishReleaseTask))]
public class DefaultTask : FrostingTask
{
}