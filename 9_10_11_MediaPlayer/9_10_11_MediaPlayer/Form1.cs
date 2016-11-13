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

namespace _9_10_11_MediaPlayer
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player.URL = "Eors.mp3";
            player.controls.stop();
        }

        private void Play_Click(object sender, EventArgs e)
        {
            Timer.Start();
            player.controls.play();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            Timer.Stop();
            player.controls.stop();
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            Timer.Stop();
            player.controls.pause();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            var cp = (int)player.controls.currentPosition;
            var vl = (int)player.currentMedia.duration;
            StateBar.Maximum = vl;
            StateBar.Value = cp;
            Duration.Text = vl.ToString() + " sec";
            CurrPos.Text = cp.ToString() + " sec";
        }

        private void StateBar_Scroll(object sender, EventArgs e)
        {
            player.controls.currentPosition = StateBar.Value;
        }

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() != DialogResult.OK) return;
            player.URL = f.FileName;
            Timer.Start();
            player.controls.play();
        }
    }
}
