using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;

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
        public const string StrRequiredVersion = "V18.0";
        private const string BasePath = "SOFTWARE\\Siemens\\Automation\\Openness\\";
        private const string ReferencedAssembly = "Siemens.Engineering";
        private const string ReferencedHmiAssembly = "Siemens.Engineering.Hmi";
        private static string _assemblyPath = "";
        private static string _assemblyPathHmi = "";

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


        /// <summary>
        /// Retrieve the path from assembly by version
        /// </summary>
        /// <param name="version"></param>
        /// <param name="assembly"></param>
        /// <returns></returns>
        public static string GetAssemblyPath(string version, string assembly)
        {
            var libraries = OpennessLibraries.GetOpennessLibraries();
            var portalVersion = new Version(version);
            var apiVersion = new Version(assembly);
            _assemblyPath = libraries.Where(e => e.TiaPortalVersion.Major == portalVersion.Major &&
                                                     e.TiaPortalVersion.Minor == portalVersion.Minor).SingleOrDefault(e => e.PublicApiVersion.Major == apiVersion.Major &&
                                                                                                                           e.PublicApiVersion.Minor == apiVersion.Minor)?.LibraryFilePath;

            return null;
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
            var engineeringVersion = GetEngineeringVersions();

            var requiredVersion = (from version in engineeringVersion
                                   where Convert.ToDecimal(version) >= Convert.ToDecimal(StrRequiredVersion.Substring(1, 4))
                                   select version).FirstOrDefault();

            return requiredVersion;
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
                        if(version == StrRequiredVersion)
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
