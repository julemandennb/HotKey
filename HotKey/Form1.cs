using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Threading;
using musicPlayClass;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        private musicPalyClass musicPalyClass;

        public Form1()
        {
            InitializeComponent();

            this.musicPalyClass = new musicPalyClass();
        }

        bool isRunning = true;

        public Thread TH;

        private void Form1_Load(object sender, EventArgs e)
        {

            //start check key
            TH = new Thread(Keyboardd);
            TH.SetApartmentState(ApartmentState.STA);
            TH.Start();
        }

        /// <summary>
        /// check key 
        /// </summary>
        void Keyboardd()
        {
            
            while(isRunning)
            {
                Thread.Sleep(40);
                if((Keyboard.GetKeyStates(Key.E) & KeyStates.Down) > 0 && (Keyboard.GetKeyStates(Key.X) & KeyStates.Down) > 0)
                {
                    this.musicPalyClass.Play();
                }
                else if((Keyboard.GetKeyStates(Key.W) & KeyStates.Down) > 0 && (Keyboard.GetKeyStates(Key.E) & KeyStates.Down) > 0 && (Keyboard.GetKeyStates(Key.B) & KeyStates.Down) > 0)
                {
                    System.Diagnostics.Process.Start("http://google.com");
                }

            }
        }

        /// <summary>
        /// if close app end key check
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            isRunning = false;

            TH.Abort();
        }

        /// <summary>
        /// to set on Pause or Start ket check
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPauseOrStart_Click(object sender, EventArgs e)
        {
            if(isRunning == true)
            {
                isRunning = false ;
                buttonPauseOrStart.Text = "Start";

                TH.Abort();

            }
            else
            {
                isRunning = true;
                buttonPauseOrStart.Text = "Pause";

                TH = new Thread(Keyboardd);
                TH.SetApartmentState(ApartmentState.STA);
                TH.Start();
            }
        }
    }
}
