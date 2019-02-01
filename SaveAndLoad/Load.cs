using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SaveAndLoad
{
    public class Load
    {

        private string pathstr = "";

        public Load()
        {

            this.pathstr = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\HotKey";
            if (!Directory.Exists(this.pathstr))
            {
                Directory.CreateDirectory(this.pathstr);
            }


        }


    }
}
