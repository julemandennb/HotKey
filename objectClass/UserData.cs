using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectClass
{
    public class UserData
    {

        public string deviceNumber;

        public List<string> openEXEOrWebPath;

        public UserData()
        {
            this.deviceNumber = "00000000-0000-0000-0000-000000000000";
            this.openEXEOrWebPath = new List<string>();
        }


       


    }
}
