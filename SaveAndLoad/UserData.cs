using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveAndLoad
{
    public class UserData
    {

        private string deviceNumber;

        public UserData()
        {
            this.deviceNumber = "00000000-0000-0000-0000-000000000000";
        }


        public string deviceNumberSetGet { get { return this.deviceNumber; } set { if (value !="") { this.deviceNumber = value; } } }


    }
}
