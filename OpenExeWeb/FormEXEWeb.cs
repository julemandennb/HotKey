﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace OpenExeWeb
{
    public partial class FormEXEWeb : Form
    {

        public string path;
        private bool isCustom = true;


        public FormEXEWeb(string path)
        {
            InitializeComponent();

            this.path = path;
            this.textBoxUrlOrPaht.Text = path;


        }

        private void buttonPaht_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Exe file|*.exe;*.bat;*.cmd";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.path = openFileDialog.FileName;
                this.textBoxUrlOrPaht.Text = this.path;
                this.isCustom = false;

            }

        }

        /// <summary>
        /// to get a path to exe or url
        /// </summary>
        /// <returns>path or url or ""</returns>
        public string GetPath()
        {
            string newPaht = "";

            //if custom is true use hav add som to text box
            if (this.isCustom)
            {
                //check if path to a file is if not check if this is a url 
                if (!File.Exists(this.path))
                {

                    //check url 
                    Uri uriResult;
                    bool result = Uri.TryCreate(this.path, UriKind.Absolute, out uriResult)
                        && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);

                    if(!result)
                    {
                        //add http to string
                        this.path = "http://" + this.path;

                        //check again
                            result = Uri.TryCreate(this.path, UriKind.Absolute, out uriResult)
                            && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);


                        if (result)
                        {
                            newPaht = this.path;
                        }
                    }
                    else
                    {
                        newPaht = this.path;
                    }

                }
                else
                {
                    newPaht = this.path;
                }
            }
            return newPaht;
        }
    }
}
