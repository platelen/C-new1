using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessMelody
{
    public partial class fGame : Form
    {

        Random rnd = new  Random();
        public fGame()
        {
            InitializeComponent();
        }

        void MakeMusic()
        {
            int n = rnd.Next(0, Victorina.list.Count);
            WMP.URL = Victorina.list[n];
            //WMP.Ctlcontrols.play();
            Victorina.list.RemoveAt(n);
            lbMelodyCount.Text = Victorina.list.Count.ToString();
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            timer1.Start();
            MakeMusic();
        }

        private void fGame_Load(object sender, EventArgs e)
        {
            lbMelodyCount.Text = Victorina.list.Count.ToString();
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = Victorina.gameDuraction;
            Victorina.ReadSettings();
            Victorina.ReadMusic();
        }

        private void lbCounter1_Click(object sender, EventArgs e)
        {

        }

        private void fGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            WMP.Ctlcontrols.stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            if(progressBar1.Value==progressBar1.Maximum)
            {
                timer1.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            WMP.Ctlcontrols.pause();
        }

        private void btContinue_Click(object sender, EventArgs e)
        {
            timer1.Start();
            WMP.Ctlcontrols.play();
        }
    }
}
