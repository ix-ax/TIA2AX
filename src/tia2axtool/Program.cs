using System.Diagnostics;
using System.Reflection;

namespace tia2axtool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This is a workaround to make a .net48 assembly work as dotnet tool
            var entry = new FileInfo(Assembly.GetEntryAssembly().Location);
            var folder = entry.Directory.FullName;

            var exePath = Path.Combine(folder, "V18_0_tia2ax.exe");
            Process.Start(new ProcessStartInfo(exePath) { Arguments = string.Join(" ", args) });
        }
    }
}