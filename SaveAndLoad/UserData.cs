using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveAndLoad
{
    public class UserData
    {

        private string deviceName;
        private byte deviceNumber;

        public UserData()
        {
            this.deviceName = "";
            this.deviceNumber = 0;
        }


        public string deviceNameSetGet { get { return this.deviceName; } set { this.deviceName = value; } }
        public byte deviceNumberSetGet { get { return this.deviceNumber; } set { if (value >= 0) { this.deviceNumber = value; } } }


    }
}
