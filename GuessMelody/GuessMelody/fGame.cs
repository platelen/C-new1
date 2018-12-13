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
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            MakeMusic();
        }

        private void fGame_Load(object sender, EventArgs e)
        {
            Victorina.ReadSettings();
            Victorina.ReadMusic();
        }

        private void lbCounter1_Click(object sender, EventArgs e)
        {

        }

        private void fGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            WMP.Ctlcontrols.stop();
        }
    }
}
