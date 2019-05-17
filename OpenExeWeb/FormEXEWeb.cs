using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenExeWeb
{
    public partial class FormEXEWeb : Form
    {

        public string path;
        private bool isUrl = false;
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
                this.isUrl = false;
                this.textBoxUrlOrPaht.Text = this.path;
                this.isCustom = false;

            }








        }
    }
}
