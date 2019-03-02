using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace SaveAndLoad
{
    internal class Load : SaveAndLoadClass
    {

        internal Load()
        {
            
        }

        internal UserData GetUser()
        {
            UserData userData = new UserData();

            using (StreamReader r = new StreamReader(this.pathstr+"\\UserData.txt"))
            {
                string json = r.ReadToEnd();
                dynamic stuff = JsonConvert.DeserializeObject<dynamic>(json);




                userData.deviceNumber = stuff.deviceNumber;

            }






            return userData;
        }


    }
}
