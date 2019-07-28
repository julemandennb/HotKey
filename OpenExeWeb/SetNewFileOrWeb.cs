using objectClass;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenExeWeb
{
    public class SetNewFileOrWeb
    {

        public UserData userData;

        public SetNewFileOrWeb(UserData userData)
        {
            this.userData = userData;
        }

        /// <summary>
        /// to open file or web side
        /// </summary>
        /// <param name="num">num in array</param>
        public void open(byte num = 0)
        {

            string path = this.userData.openEXEOrWebPath[num];
            string newPaht = "";

            //check if path to a file is if not check if this is a url 
            if (!File.Exists(path))
            {
                

                //check url 
                Uri uriResult;
                bool result = Uri.TryCreate(path, UriKind.Absolute, out uriResult)
                    && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);

                if (!result)
                {
                    //add http to string
                    path = "http://" + path;

                    //check again
                    result = Uri.TryCreate(path, UriKind.Absolute, out uriResult)
                    && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);


                    if (result)
                    {
                        newPaht = path;
                    }
                }
                else
                {
                    newPaht = path;
                }

            }
            else
            {
                newPaht = path;
            }

            Process.Start(newPaht);


        }

    }
}
