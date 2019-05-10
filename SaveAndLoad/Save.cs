using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using objectClass;

namespace SaveAndLoad
{
    internal class Save : SaveAndLoadClass
    {


        internal Save()
        {


        }

        /// <summary>
        /// make userdata to JSON str and save to a txt file
        /// </summary>
        /// <param name="userData">user setting</param>
        internal void SaveUser(UserData userData)
        {
            string JSON = JsonConvert.SerializeObject(userData);

            File.WriteAllText(this.pathstr + "\\UserData.txt", JSON);
        }


    }
}
