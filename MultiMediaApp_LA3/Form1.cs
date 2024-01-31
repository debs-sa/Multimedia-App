using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.Threading;

namespace MultiMediaApp_LA3
{
    public partial class MultiMediaForm : Form
    {
        public MultiMediaForm()
        {
            InitializeComponent();
            WindowsMediaPlayer.uiMode = "none";
        }

        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openImage = new OpenFileDialog();
            if (openImage.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openImage.FileName;
            }
        }

        private void btnSystemSounds_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer("systemsounds.wav");
            sound.Play();
        }

        private void btnRunSound_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer("runsound.wav");
            sound.Play();
        }

        private void btnStopSound_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer("runsound.wav");
            sound.Stop();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            ofd.Title = "Open File";
            ofd.Filter = "All Files  | *.* | Audio | *.wav";
            ofd.FilterIndex = 1;
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.txtPath.Text = ofd.FileName;
            }
        }

        private void btnPlayMP3_Click(object sender, EventArgs e)
        {
            //player2.URL = "TestingMusic.mp3";
            //player2.controls.play();
        }

        private void btnStopMP3_Click(object sender, EventArgs e)
        {
            //player2.controls.stop();
        }

        private void btnPlayVideo_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer.Ctlcontrols.play();
        }

        private void btnPauseVideo_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer.Ctlcontrols.pause();
        }

        private void btnStopVideo_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer.Ctlcontrols.stop();
        }

        string vPath;

        private void btnOpenVideo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd2 = new OpenFileDialog();
            ofd2.Title = "Open Video";
            ofd2.Filter = "All Files | *.* | Video | *.mp4";
            ofd2.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //o arquivo tem que estar no desktop
            if(ofd2.ShowDialog() == DialogResult.OK)
            {
                vPath = ofd2.FileName;
                WindowsMediaPlayer.URL = vPath;
            }
        }
        private void comboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxLanguage.SelectedIndex)
            {
                case 0:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                    break;

                    case 1:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fr");
                    break;     
            }
            this.Controls.Clear();
            InitializeComponent();
        }
    }
}
