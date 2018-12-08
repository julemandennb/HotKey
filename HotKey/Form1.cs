﻿using System;
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
using HotKey;

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
                if((Keyboard.GetKeyStates(Key.S) & KeyStates.Down) > 0 && (Keyboard.GetKeyStates(Key.U) & KeyStates.Down) > 0)
                {
                    byte numberSonuder = this.keyNumber();

                    if (numberSonuder != 10)
                    {
                        this.musicPalyClass.playSound(0, numberSonuder); 
                    } 
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

        /// <summary>
        /// all number on key not numpad
        /// </summary>
        /// <returns></returns>
        private byte keyNumber()
        {
            if ((Keyboard.GetKeyStates(Key.D0) & KeyStates.Down) > 0)
            {
                return 0;
            }
            else if ((Keyboard.GetKeyStates(Key.D1) & KeyStates.Down) > 0)
            {
                return 1;
            }
            else if ((Keyboard.GetKeyStates(Key.D2) & KeyStates.Down) > 0)
            {
                return 2;
            }
            else if ((Keyboard.GetKeyStates(Key.D3) & KeyStates.Down) > 0)
            {
                return 3;
            }
            else if ((Keyboard.GetKeyStates(Key.D4) & KeyStates.Down) > 0)
            {
                return 4;
            }
            else if ((Keyboard.GetKeyStates(Key.D5) & KeyStates.Down) > 0)
            {
                return 5;
            }
            else if ((Keyboard.GetKeyStates(Key.D6) & KeyStates.Down) > 0)
            {
                return 6;
            }
            else if ((Keyboard.GetKeyStates(Key.D7) & KeyStates.Down) > 0)
            {
                return 7;
            }
            else if ((Keyboard.GetKeyStates(Key.D8) & KeyStates.Down) > 0)
            {
                return 8;
            }
            else if ((Keyboard.GetKeyStates(Key.D9) & KeyStates.Down) > 0)
            {
                return 9;
            }


            return 10;
        }

        private void setting_Click(object sender, EventArgs e)
        {
            if (isRunning == true)
            {
                isRunning = false;
                buttonPauseOrStart.Text = "Start";

                TH.Abort();

            }

            SettingForm settingForm = new SettingForm();

            settingForm.ShowDialog();



        }
    }
}
