using Microsoft.Win32;
using System.Diagnostics;
using System.Reflection;
using System.Security.AccessControl;

namespace tia2axtool
{
    internal class Program
    {
        private const string LibraryKey = "SOFTWARE\\Siemens\\Automation\\Openness\\18.0\\PublicAPI\\18.0.0.0";
        private const string LibraryName = "Siemens.Engineering";

        static void Main(string[] args)
        {
            string libraryPath = GetLibraryFilePath();
            if (!string.IsNullOrEmpty(libraryPath))
            {
                // This is a workaround to get the local dll for the Openness
                var entry = new FileInfo(Assembly.GetEntryAssembly().Location);
                var folder = entry.Directory.FullName;
                File.Copy(libraryPath, Path.Combine(folder, LibraryName + ".dll"), true);
                File.Copy(libraryPath.Replace("dll", "xml"), Path.Combine(folder, LibraryName + ".xml"), true);

                // This is a workaround to make a .net48 assembly work as dotnet tool

                var exePath = Path.Combine(folder, "V18_0_tia2ax.exe");
                Process.Start(new ProcessStartInfo(exePath) { Arguments = string.Join(" ", args) });
            }
        }

        private static string GetLibraryFilePath()
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
    }
}