using System.Collections.Generic;

namespace Tia2Ax.DTOs
{
    public class PlcItem
    {
        #region properties

        public string Name
        {
            get;
            set;
        }

        public string DeviceName
        {
            get;
            set;
        }

        public string Classification
        {
            get;
            set;
        }

        public string GroupPathInProject
        {
            get;
            set;
        }

        public IList<string> ConfiguredSubnets
        {
            get;
            set;
        }

        public IList<ModuleItem> LocalModules
        {
            get;
            set;
        }
        public IList<ModuleItem> DistributedModules
        {
            get;
            set;
        }
        #endregion // properties
    }
}
