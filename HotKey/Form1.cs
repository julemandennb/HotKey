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



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool isRunning = true;

        public Thread TH;

        private void Form1_Load(object sender, EventArgs e)
        {
            TH = new Thread(Keyboardd);
            TH.SetApartmentState(ApartmentState.STA);
            TH.Start();
        }

        void Keyboardd()
        {
            while(isRunning)
            {
                Thread.Sleep(40);
                if((Keyboard.GetKeyStates(Key.A) & KeyStates.Down) > 0 && (Keyboard.GetKeyStates(Key.S) & KeyStates.Down) > 0)
                {

                }

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            isRunning = false;

            TH.Abort();
        }

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
