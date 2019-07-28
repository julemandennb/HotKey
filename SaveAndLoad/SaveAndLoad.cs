using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using objectClass;
using SaveAndLoad;

namespace SaveAndLoad
{
    public class SaveAndLoadClass
    {
        protected string pathstr = "";

        /// <summary>
        /// make to call save and load
        /// </summary>
        public SaveAndLoadClass()
        {
            //get paht to fold to save and load for
            this.pathstr = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\HotKey";
            //if fold is not make, make fold and sounder fold and new profil
            if (!Directory.Exists(this.pathstr))
            {
                Directory.CreateDirectory(this.pathstr);
                Directory.CreateDirectory(this.pathstr+ "/sounder");
                new Save().SaveUser(new UserData());
            }
        }

        /// <summary>
        /// to get profil from fold
        /// </summary>
        /// <returns></returns>
        public UserData load()
        {
            UserData userData = new UserData();

            userData = new Load().GetUser();

            userData = this.checkUserData(userData);

            return userData;
        }

        /// <summary>
        /// to save profil to fold
        /// </summary>
        /// <param name="userData"></param>
        public void save(UserData userData)
        {
            new Save().SaveUser(userData);
        }

        /// <summary>
        /// to check if all val is right
        /// </summary>
        /// <param name="userData"></param>
        /// <returns></returns>
        private UserData checkUserData(UserData userData)
        {
            if(userData.openEXEOrWebPath.Length < 10)
            {
                userData.openEXEOrWebPath = new string[10];
            }


            return userData;
        }





    }
}





