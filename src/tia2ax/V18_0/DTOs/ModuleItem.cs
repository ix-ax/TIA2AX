using System.Collections.Generic;

namespace Tia2Ax.DTOs
{
    public class ModuleItem
    {
        public string FullName
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string OrderNumber
        {
            get;
            set;
        }

        public string FirmwareVersion
        {
            get;
            set;
        }

        public int PositionNumber
        {
            get;
            set;
        }

        public IList<AddressItem> AddressItems
        {
            get;
            set;
        }
    }
}
