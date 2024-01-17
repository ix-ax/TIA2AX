using Siemens.Engineering.HW;

namespace Tia2Ax.DTOs
{
    public class AddressItem
    {
        public string Controller
        {
            get;
            set;
        }
        public AddressIoType IoType
        {
            get;
            set;
        }
        public int StartAddress
        {
            get;
            set;
        }


        public int BitLength
        {
            get;
            set;
        }


        public int ByteLength
        {
            get;
            set;
        }
    }
}
