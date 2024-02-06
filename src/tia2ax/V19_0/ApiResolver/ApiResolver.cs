using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Security.AccessControl;

namespace Tia2Ax.Utils
{
    /// <summary>
    /// Definition of helper functionality to resolve api dll, modules and options
    /// </summary>
    public static class ApiResolver
    {
        /// <summary>
        /// Required min version of engineering dll
        /// </summary>
        public const string StrRequiredVersion = "V19.0";
        private const string BasePath = "SOFTWARE\\Siemens\\Automation\\Openness\\";
        private const string LibraryKey = "SOFTWARE\\Siemens\\Automation\\Openness\\19.0\\PublicAPI\\19.0.0.0";
        private const string LibraryName = "Siemens.Engineering";

        /// <summary>
        /// Get version info from registry key
        /// </summary>
        /// <returns></returns>
        public static List<string> GetEngineeringVersions()
        {
            RegistryKey key = GetRegistryKey(BasePath);

            if (key != null)
            {
                try
                {
                    var names = key.GetSubKeyNames().OrderBy(x => x).ToList();

                    var result = (from item in names
                                  where Convert.ToDecimal(item.Substring(0, 4)) >= Convert.ToDecimal(StrRequiredVersion.Substring(1, 4))
                                  select item.Substring(0, 4)).ToList();

                    key.Dispose();

                    return result;
                }
                finally
                {
                    key.Dispose();
                }
            }

            return new List<string>();
        }

        private static RegistryKey GetRegistryKey(string keyName)
        {
            RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
            RegistryKey key = baseKey.OpenSubKey(keyName);
            if (key == null)
            {
                baseKey.Dispose();
                baseKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Default);
                key = baseKey.OpenSubKey(keyName);
            }
            if (key == null)
            {
                baseKey.Dispose();
                baseKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32);
                key = baseKey.OpenSubKey(keyName);
            }
            baseKey.Dispose();

            return key;
        }


        /// <summary>
        /// Check if openness api is installed
        /// </summary>
        /// <returns></returns>
        public static bool IsOpennessInstalled()
        {
            return !string.IsNullOrEmpty(GetLibraryFilePath());
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


        /// <summary>
        /// Check if required TiaVersion is installed
        /// </summary>
        /// <returns></returns>
        public static bool IsTiaInstalled()
        {
            try
            {
                ObservableCollection<string> EngineeringVersions = new ObservableCollection<string>(GetEngineeringVersions());
                if (EngineeringVersions != null && EngineeringVersions.Count > 0)
                {
                    foreach (var version in EngineeringVersions)
                    {
                        if(version == StrRequiredVersion.Substring(1, 4))
                        {
                            return true;
                        }
                    }
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            return false;
        }
    }
}
