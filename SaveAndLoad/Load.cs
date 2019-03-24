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
        /// <summary>
        /// to load txt file hav JSON str in to make UserData
        /// </summary>
        /// <returns>UserData</returns>
        internal UserData GetUser()
        {
            UserData userData = new UserData();

            using (StreamReader r = new StreamReader(this.pathstr+"\\UserData.txt"))
            {
                string json = r.ReadToEnd();
                userData = JsonConvert.DeserializeObject<UserData>(json);
            }

            return userData;
        }


    }
}
