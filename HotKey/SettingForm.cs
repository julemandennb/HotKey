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

namespace HotKey
{
    public partial class SettingForm : Form
    {

        private musicPalyClass musicPalyClass;

        public SettingForm()
        {
            InitializeComponent();

            this.musicPalyClass = new musicPalyClass();
        }

        private void button0play_Click(object sender, EventArgs e)
        {
            this.musicPalyClass.playSound(0, 0);
        }

        private void button9play_Click(object sender, EventArgs e)
        {
            this.musicPalyClass.playSound(0, 9);
        }

        private void button8play_Click(object sender, EventArgs e)
        {
            this.musicPalyClass.playSound(0, 8);
        }

        private void button7play_Click(object sender, EventArgs e)
        {
            this.musicPalyClass.playSound(0, 7);
        }

        private void button6play_Click(object sender, EventArgs e)
        {
            this.musicPalyClass.playSound(0, 6);
        }

        private void button5play_Click(object sender, EventArgs e)
        {
            this.musicPalyClass.playSound(0, 5);
        }

        private void button4play_Click(object sender, EventArgs e)
        {
            this.musicPalyClass.playSound(0, 4);
        }

        private void button3play_Click(object sender, EventArgs e)
        {
            this.musicPalyClass.playSound(0, 3);
        }

        private void button2play_Click(object sender, EventArgs e)
        {
            this.musicPalyClass.playSound(0, 2);
        }

        private void button1play_Click(object sender, EventArgs e)
        {
            this.musicPalyClass.playSound(0, 1);
        }
    }
}
