using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using musicPlayClass;
using SaveAndLoad;
using Microsoft.VisualBasic;
using objectClass;
using OpenExeWeb;

namespace HotKey
{
    public partial class SettingForm : Form
    {
        public UserData userData;

        private List<deviceName> deviceList;

        private musicPalyClass musicPalyClass;

        public int deviceToPlayOn = 0;

        public SettingForm(UserData userData)
        {
            InitializeComponent();

            this.userData = userData;

            this.musicPalyClass = new musicPalyClass();


            this.deviceList = this.musicPalyClass.getOutPutList();

            int number = 0;
            foreach (deviceName device in this.deviceList)
            {

                ComboboxItem item = new ComboboxItem(device.name, number);

                comboBoxDevice.Items.Add(item);

                if (device.Guid == this.userData.deviceNumber)
                    comboBoxDevice.SelectedIndex = number;

                    number++;

                

            }


        }

        /// <summary>
        /// to play music on this key you click on 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonplay_Click(object sender, EventArgs e)
        {
            byte num = this.getButtonID(sender);


            if(num != 11)
            {
                this.musicPalyClass.playSound(this.deviceToPlayOn, num);
            }
            else
            {
                MessageBox.Show("Cannot find button", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        /// <summary>
        /// to change music on key you hav click on
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChange_Click(object sender, EventArgs e)
        {


            byte num = this.getButtonID(sender);

            if (num != 11)
            {


                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "mp3 Files|*.mp3";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;




                    this.musicPalyClass.setNewSound(num, filePath);







                }
            }
            else
            {
                MessageBox.Show("Cannot find button", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// to get number of button
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        private byte getButtonID(object sender)
        {
            Button button = (Button)sender;
            string buttonId = button.Name;

            byte num = 11;

            switch (buttonId)
            {
                case "button1play":
                case "buttonChange1":
                case "ChangeExeWeb1":
                    num = 1;
                    break;
                case "button2play":
                case "buttonChange2":
                case "ChangeExeWeb2":
                    num = 2;
                    break;
                case "button3play":
                case "buttonChange3":
                case "ChangeExeWeb3":
                    num = 3;
                    break;
                case "button4play":
                case "buttonChange4":
                case "ChangeExeWeb4":
                    num = 4;
                    break;
                case "button5play":
                case "buttonChange5":
                case "ChangeExeWeb5":
                    num = 5;
                    break;
                case "button6play":
                case "buttonChange6":
                case "ChangeExeWeb6":
                    num = 6;
                    break;
                case "button7play":
                case "buttonChange7":
                case "ChangeExeWeb7":
                    num = 7;
                    break;
                case "button8play":
                case "buttonChange8":
                case "ChangeExeWeb8":
                    num = 8;
                    break;
                case "button9play":
                case "buttonChange9":
                case "ChangeExeWeb9":
                    num = 9;
                    break;
                case "button0play":
                case "buttonChange0":
                case "ChangeExeWeb0":
                    num = 0;
                    break;

                default:
                    num = 11;
                    break;
            }


            return num;
        }

        private void comboBoxDevice_SelectedIndexChanged(object sender, EventArgs e)
        {

            ComboboxItem ComboboxItemObj = comboBoxDevice.SelectedItem as ComboboxItem;

            this.deviceToPlayOn = ComboboxItemObj.Value;

        }

        private void SettingForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            this.userData.deviceNumber = this.musicPalyClass.getOutPutGuid(this.deviceToPlayOn);

        }


        private void ButtonExeWeb_Click(object sender, EventArgs e)
        {
            byte num = this.getButtonID(sender);


            if (num != 11)
            {

                FormEXEWeb formEXEWeb = new FormEXEWeb("");
                formEXEWeb.ShowDialog();
                formEXEWeb.GetPath();


            }
            else
            {
                MessageBox.Show("Cannot find button", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }





    }

















    public class ComboboxItem
    {
        public string Text { get; set; }
        public int Value { get; set; }


        public ComboboxItem(string Text, int Value)
        {
            this.Text = Text;
            this.Value = Value;

        }

        public override string ToString()
        {
            return Text;
        }
    }


}
