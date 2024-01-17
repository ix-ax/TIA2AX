using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.AccessControl;

namespace Tia2Ax.Utils
{
    /// <summary>
    /// Determine installed openness libraries
    /// </summary>
    public static class OpennessLibraries
    {
        /// <summary>
        /// Get installed openness libraries
        /// </summary>
        /// <returns></returns>
        public static IReadOnlyList<OpennessVersion> GetOpennessLibraries()
        {
            var opennessVersions = new List<OpennessVersion>();

            if (Environment.Is64BitOperatingSystem)
            {
                var key = Path.Combine("SOFTWARE", "Siemens", "Automation", "Openness");
                using (var baseKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
                {
                    using (var registryKey = baseKey.OpenSubKey(key, RegistryKeyPermissionCheck.ReadSubTree, RegistryRights.ReadKey))
                    {
                        var tiaPortalVersions = registryKey?.GetSubKeyNames();
                        if (tiaPortalVersions != null)
                        {
                            foreach (var tiaPortalVersion in tiaPortalVersions)
                            {
                                using (var publicApi = registryKey.OpenSubKey(Path.Combine(tiaPortalVersion, "PublicAPI"), RegistryKeyPermissionCheck.ReadSubTree, RegistryRights.ReadKey))
                                {
                                    var publicApis = publicApi?.GetSubKeyNames();
                                    if (publicApis != null)
                                    {
                                        foreach (var publicApiVersion in publicApis)
                                        {
                                            using (var openness = publicApi.OpenSubKey(publicApiVersion, RegistryKeyPermissionCheck.ReadSubTree, RegistryRights.ReadKey))
                                            {
                                                var library = openness?.GetValue("Siemens.Engineering") as string;

                                                if (!string.IsNullOrWhiteSpace(library) && File.Exists(library))
                                                {
                                                    var portalVersion = new Version(tiaPortalVersion);
                                                    var apiVersion = new Version(publicApiVersion);
                                                    var opennessVersion = new OpennessVersion(portalVersion, library, apiVersion);
                                                    opennessVersions.Add(opennessVersion);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return opennessVersions.AsReadOnly();
        }
    }
}
