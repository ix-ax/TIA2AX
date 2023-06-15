using System;
using System.IO;
using System.Reflection;

namespace Tia2Ax.Interfaces
{
    public static class ApiResolver
    {
        #region constants

        public const string Version = "V18";
        private const string LibraryName = "Siemens.Engineering";
        private const string DllName = "Siemens.Engineering.V18_0.dll";

        #endregion // constants

        #region methods

        /// <summary>
        /// Determines the API library to be loaded 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static Assembly AssemblyResolver(object sender, ResolveEventArgs args)
        {
            var lookupName = new AssemblyName(args.Name);
            if (lookupName.Name.Equals(LibraryName, StringComparison.OrdinalIgnoreCase))
            {
                var libraryFilePath = GetLibraryFilePath();
                if (!string.IsNullOrWhiteSpace(libraryFilePath))
                {
                    var suggestedName = AssemblyName.GetAssemblyName(libraryFilePath);
                    return Assembly.Load(suggestedName);
                }
            }
            return null;
        }

        /// <summary>
        /// Determines if the .dll version of the API library is present
        /// </summary>
        /// <returns></returns>
        public static bool IsDllPresent()
        {
            return !string.IsNullOrWhiteSpace(GetLibraryFilePath());
        }

        private static string GetLibraryFilePath()
        {

            string libraryFilePath = Path.GetFullPath(Path.Combine(Assembly.GetCallingAssembly().Location, @"..\", DllName));
            if (!string.IsNullOrWhiteSpace(libraryFilePath) && File.Exists(libraryFilePath))
            {
                return libraryFilePath;
            }
            return null;
        }
        #endregion
    }
}
