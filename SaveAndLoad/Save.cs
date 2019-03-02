using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace SaveAndLoad
{
    internal class Save : SaveAndLoadClass
    {


        internal Save()
        {


        }


        internal void SaveUser(UserData userData)
        {
            string JSON = JsonConvert.SerializeObject(userData);

            File.WriteAllText(this.pathstr + "\\UserData.txt", JSON);
        }


    }
}
