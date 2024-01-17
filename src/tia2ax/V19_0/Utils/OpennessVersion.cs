using System;

namespace Tia2Ax.Utils
{
    /// <summary>
    /// Version infos
    /// </summary>
    public sealed class OpennessVersion
    {
        /// <summary>
        /// The version of TIA Portal
        /// </summary>
        public Version TiaPortalVersion { get; }

        /// <summary>
        /// The library path
        /// </summary>
        public string LibraryFilePath { get; }

        /// <summary>
        /// The openness api version
        /// </summary>
        public Version PublicApiVersion { get; }

        /// <summary>
        /// Set the Version infos
        /// </summary>
        /// <param name="tiaPortalVersion">version of TIA Portal</param>
        /// <param name="libraryFilePath">library path</param>
        /// <param name="publicApiVersion">openness api version</param>
        public OpennessVersion(Version tiaPortalVersion, string libraryFilePath, Version publicApiVersion)
        {
            if (tiaPortalVersion == null || tiaPortalVersion.Major == 0 &&
                tiaPortalVersion.Minor == 0 &&
                tiaPortalVersion.Build == 0 &&
                tiaPortalVersion.Revision == 0) throw new ArgumentNullException(nameof(tiaPortalVersion));

            if (string.IsNullOrWhiteSpace(libraryFilePath)) throw new ArgumentNullException(nameof(libraryFilePath));

            if (publicApiVersion == null || publicApiVersion.Major == 0 &&
                publicApiVersion.Minor == 0 &&
                publicApiVersion.Build == 0 &&
                publicApiVersion.Revision == 0) throw new ArgumentNullException(nameof(publicApiVersion));

            TiaPortalVersion = tiaPortalVersion;
            LibraryFilePath = libraryFilePath;
            PublicApiVersion = publicApiVersion;
        }
    }
}
