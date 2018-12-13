using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GuessMelody
{
    public partial class fSettings : Form
    {
        public fSettings()
        {
            InitializeComponent();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            Victorina.allDirectories = cbAllDirectoty.Checked;
            Victorina.gameDuraction = Convert.ToInt32(cbGameDuration.Text);
            Victorina.musiciDuraction = Convert.ToInt32(cbMusicDuration.Text);
            Victorina.randomStart = cbRandomStart.Checked;
            Victorina.WriteSetttings();
            this.Hide();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Set();   
            this.Hide();
        }
        void Set()
        {
            cbAllDirectoty.Checked = Victorina.allDirectories;
            cbGameDuration.Text = Victorina.gameDuraction.ToString();
            cbMusicDuration.Text = Victorina.musiciDuraction.ToString();
            cbRandomStart.Checked = Victorina.randomStart;
        }

        private void btSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                string[] music_list = Directory.GetFiles(fbd.SelectedPath, "*.mp3",cbAllDirectoty.Checked?SearchOption.AllDirectories:SearchOption.TopDirectoryOnly);
                Victorina.lastFolder = fbd.SelectedPath;
                listBox1.Items.Clear();
                listBox1.Items.AddRange(music_list);
                Victorina.list.Clear();
                Victorina.list.AddRange(music_list);
            }
        }

        private void fSettings_Load(object sender, EventArgs e)
        {
            Set();
            listBox1.Items.Clear();
            listBox1.Items.AddRange(Victorina.list.ToArray());
        }
    }
}
