using System.Collections.Generic;
using System.IO;

namespace Tia2Ax.DTOs
{
    public class ProjectItem
    {
        #region properties

        public string Name
        {
            get;
            set;
        }

        public DirectoryInfo TargetDirectory
        {
            get;
            set;
        }
        public int CurrentDeviceCount
        {
            get;
            set;
        }

        public IList<PlcItem> PlcItems
        {
            get;
            set;
        }
        #endregion // properties
    }
}
