// Build
// Copyright (c) 2023 Peter Kurhajec (PTKu), MTS,  and Contributors. All Rights Reserved.
// Contributors: https://github.com/ix-ax/TIA2AX/graphs/contributors
// See the LICENSE file in the repository root for more information.
// https://github.com/ix-ax/TIA2AX/blob/master/LICENSE
// Third party licenses: https://github.com/ix-ax/TIA2AX/blob/master/notices.md

using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Cake.Common.Tools.DotNet;
using Cake.Common.Tools.DotNet.Build;
using Cake.Common.Tools.DotNet.MSBuild;
using Cake.Common.Tools.DotNet.Run;
using Cake.Common.Tools.DotNet.Test;
using Cake.Core;
using Cake.Frosting;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Octokit;
using Polly;
using static NuGet.Packaging.PackagingConstants;
using Path = System.IO.Path;

public class BuildContext : FrostingContext
{
    public string Artifacts  => Path.Combine(Environment.WorkingDirectory.FullPath, "..//artifacts//");

    public string ArtifactsNugets => EnsureFolder(Path.Combine(Artifacts, "nugets"));

    public string PackableNugetsSlnf => Path.Combine(RootDir, "tia2ax_packableOnly.slnf");

    public string WorkDirName => Environment.WorkingDirectory.GetDirectoryName();

    public string ApiDocumentationDir => Path.GetFullPath(Path.Combine(Environment.WorkingDirectory.FullPath, "..//docs//api//"));

    public string RootDir => Path.GetFullPath(Path.Combine(Environment.WorkingDirectory.FullPath, "..//"));

    public DotNetBuildSettings DotNetBuildSettings { get; }

    public DotNetTestSettings DotNetTestSettings { get; }

    public DotNetRunSettings DotNetRunSettings { get; }

    public BuildParameters BuildParameters { get; }

    public IEnumerable<string> TargetFrameworks { get; } = new List<string>() { "net4.8" };

    public string TestResults => Path.Combine(Environment.WorkingDirectory.FullPath, "..//TestResults//");

    public string TestResultsCtrl => Path.Combine(Environment.WorkingDirectory.FullPath, "..//TestResultsCtrl//");

    public BuildContext(ICakeContext context, BuildParameters buildParameters)
        : base(context)
    {

        BuildParameters = buildParameters;

        DotNetBuildSettings = new DotNetBuildSettings()
        {
            Verbosity = buildParameters.Verbosity,
            Configuration = buildParameters.Configuration,
            NoRestore = false,
            MSBuildSettings = new DotNetMSBuildSettings()
            {
                Verbosity = DotNetVerbosity.Quiet
            }
        };

        DotNetTestSettings = new DotNetTestSettings()
        {
            Verbosity = buildParameters.Verbosity,
            Configuration = buildParameters.Configuration,
            NoRestore = true,
            NoBuild = true

        };

        DotNetRunSettings = new DotNetRunSettings()
        {
            Verbosity = buildParameters.Verbosity,
            Framework = "net4.8",
            Configuration = buildParameters.Configuration,
            NoBuild = true,
            NoRestore = true,
        };
    }

    public string GitHubUser { get; } = System.Environment.GetEnvironmentVariable("GH_USER");
    
    public string GitHubToken { get; } = System.Environment.GetEnvironmentVariable("GH_TOKEN");

    public string EnsureFolder(string path)
    {
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }

        return path;
    }
}