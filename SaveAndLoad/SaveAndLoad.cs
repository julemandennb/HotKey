using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaveAndLoad;

namespace SaveAndLoad
{
    public class SaveAndLoadClass
    {
        protected string pathstr = "";

        public SaveAndLoadClass()
        {
            this.pathstr = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\HotKey";
            if (!Directory.Exists(this.pathstr))
            {
                Directory.CreateDirectory(this.pathstr);
                Directory.CreateDirectory(this.pathstr+ "/sounder");
                new Save().SaveUser(new UserData());
            }



        }


        public UserData load()
        {
            UserData userData = new UserData();

            userData = new Load().GetUser();

            return userData;
        }

        public void save(UserData userData)
        {
            new Save().SaveUser(userData);
        }







    }
}





