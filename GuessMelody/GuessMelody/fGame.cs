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
        int duractionMusic = Victorina.musiciDuraction;
        public fGame()
        {
            InitializeComponent();
        }

        void MakeMusic()
        {
            if(Victorina.list.Count==0)
            {
                EndGame();
            }
            else
            {
                duractionMusic = Victorina.musiciDuraction;
                int n = rnd.Next(0, Victorina.list.Count);
                WMP.URL = Victorina.list[n];
                //WMP.Ctlcontrols.play();
                Victorina.list.RemoveAt(n);
                lbMelodyCount.Text = Victorina.list.Count.ToString();
            }
            
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
            lblMusicDuraction.Text = duractionMusic.ToString();
        }

        private void lbCounter1_Click(object sender, EventArgs e)
        {

        }

        private void fGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            WMP.Ctlcontrols.stop();
        }
        void EndGame()
        {
            timer1.Stop();
            WMP.Ctlcontrols.stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            duractionMusic--;
            lblMusicDuraction.Text = duractionMusic.ToString();
            if(progressBar1.Value==progressBar1.Maximum)
            {
                EndGame();
                return;
            }
            if(duractionMusic==0)
            {
                MakeMusic();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GamePause();
        }

        private void btContinue_Click(object sender, EventArgs e)
        {
            GamePlay();
        }
        void GamePause()
        {
            timer1.Stop();
            WMP.Ctlcontrols.pause();
        }
        void GamePlay()
        {
            timer1.Start();
            WMP.Ctlcontrols.play();
        }
        private void fGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Q)
            {
                GamePause();
                if(MessageBox.Show("Правильный ответ ?","Игрок 1",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    lbCounter1.Text = Convert.ToString(Convert.ToUInt32(lbCounter1.Text) + 1);
                    MakeMusic();
                }
                GamePlay();
            }
            if (e.KeyData == Keys.P)
            {
                GamePause();
                if (MessageBox.Show("Правильный ответ ?", "Игрок 2", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lbCounter2.Text = Convert.ToString(Convert.ToUInt32(lbCounter2.Text) + 1);
                    MakeMusic();
                }
                GamePlay();
            }
        }

        private void lblMusicDuraction_Click(object sender, EventArgs e)
        {

        }
    }
}
