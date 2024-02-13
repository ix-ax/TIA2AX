using CommandLine;
using Microsoft.Win32;
using System.Diagnostics;
using System.Reflection;
using System.Security.AccessControl;

namespace tia2axtool
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Parser.Default.ParseArguments<Options>(args)
                .WithParsed(o =>
                {
                    string LibraryKey = "";
                    string LibraryName = "";
                    string exeName = "";

                    if (o.TiaSourceProject.EndsWith("ap18"))
                    {
                        LibraryKey = "SOFTWARE\\Siemens\\Automation\\Openness\\18.0\\PublicAPI\\18.0.0.0";
                        LibraryName = "Siemens.Engineering";
                        exeName = "V18_0_tia2ax.exe";
                    }

                    else if (o.TiaSourceProject.EndsWith("ap19"))
                    {
                        LibraryKey = "SOFTWARE\\Siemens\\Automation\\Openness\\19.0\\PublicAPI\\19.0.0.0";
                        LibraryName = "Siemens.Engineering";
                        exeName = "V19_0_tia2ax.exe";
                    }
                    else
                    {
                        Console.WriteLine("Not supported version!");
                    }

                    try
                    {
                        string libraryPath = GetLibraryFilePath(LibraryKey, LibraryName);
                        if (!string.IsNullOrEmpty(libraryPath))
                        {
                            // This is a workaround to get the local dll for the Openness
                            var entry = new FileInfo(Assembly.GetEntryAssembly().Location);
                            var folder = entry.Directory.FullName;
                            File.Copy(libraryPath, Path.Combine(folder, LibraryName + ".dll"), true);
                            File.Copy(libraryPath.Replace("dll", "xml"), Path.Combine(folder, LibraryName + ".xml"), true);

                            // This is a workaround to make a .net48 assembly work as dotnet tool

                            var exePath = Path.Combine(folder, exeName);
                            Process.Start(new ProcessStartInfo(exePath) { Arguments = string.Join(" ", args) });
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        throw;
                    }
                });

        }

        private static string GetLibraryFilePath(string LibraryKey, string LibraryName)
        {
            using (var baseKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            {
                using (var registryKey = baseKey.OpenSubKey(LibraryKey, RegistryKeyPermissionCheck.ReadSubTree, RegistryRights.ReadKey))
                {
                    var libraryFilePath = registryKey?.GetValue(LibraryName) as string;
                    if (!string.IsNullOrWhiteSpace(libraryFilePath) && File.Exists(libraryFilePath))
                    {
                        return libraryFilePath;
                    }
                }
            }
            return null;
        }

        internal class Options
        {
            [Option('x', "tia-source-project", Required = true, HelpText = "TIA portal source project")]
            public string TiaSourceProject { get; set; }

            [Option('o', "output-folder", Required = true,
                HelpText = "Output project folder where generator emits result.")]
            public string OutputProjectFolder { get; set; }

            [Option('i', "io", Required = false, HelpText = "Export IO addresses")]
            public bool IO { get; set; }

            [Option('h', "hwid", Required = false, HelpText = "Export hardware identifiers")]
            public bool HwId { get; set; }
        }
    }
}