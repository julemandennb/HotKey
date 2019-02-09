using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaveAndLoad;

namespace SaveAndLoad
{
    public class SaveAndLoad
    {
        protected string pathstr = "";

        public SaveAndLoad()
        {
            this.pathstr = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\HotKey";
            if (!Directory.Exists(this.pathstr))
            {
                Directory.CreateDirectory(this.pathstr);
            }



        }


        public UserData load()
        {
            UserData userData = new UserData();

            return userData;
        }







    }
}





