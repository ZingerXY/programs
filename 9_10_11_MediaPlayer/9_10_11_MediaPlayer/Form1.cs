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
            //player.currentPlaylist = player.playlistCollection.newPlaylist("newplaylist");
            player.controls.stop();
            player.settings.volume = trackBar2.Value;

            listView1.Columns.Add("Autor");
            listView1.Columns.Add("album");
        }
        // Старт воспроизведения
        private void Play_Click(object sender, EventArgs e)
        {
            Timer.Start();
            player.controls.play();
            updateList();
        }
        // Стоп воспроизведения
        private void Stop_Click(object sender, EventArgs e)
        {
            Timer.Stop();
            player.controls.stop();
            player.controls.currentPosition = 0;
            CurrPos.Text = "0 sec";
            StateBar.Value = 0;
        }
        // Пауза
        private void Pause_Click(object sender, EventArgs e)
        {
            Timer.Stop();
            player.controls.pause();
        }
        // Движение бара и обновление времени воспроизведения
        private void Timer_Tick(object sender, EventArgs e)
        {
            var cp = (int)player.controls.currentPosition;
            var vl = (int)player.currentMedia.duration;
            StateBar.Maximum = vl;
            StateBar.Value = cp;
            Duration.Text = vl.ToString() + " sec";
            CurrPos.Text = cp.ToString() + " sec";
        }
        // Перемотка записи
        private void StateBar_Scroll(object sender, EventArgs e)
        {
            player.controls.currentPosition = StateBar.Value;
        }
        // Открытие записи
        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            
            if (f.ShowDialog() != DialogResult.OK) return;
            //player.URL = f.FileName;
            player.playlistCollection.newPlaylist("myplaylist");
            IWMPMedia media = player.newMedia(f.FileName);
            //playlist.appendItem(media);
         
            //player.currentPlaylist = playlist;
            player.currentPlaylist.appendItem(media);
            updateList();

            Timer.Start();
            //player.controls.play();
        }

        private void updateList()
        {
            listView1.Items.Clear();
            for (int i = 0; i < player.currentPlaylist.count; i++)
            {
                ListViewItem record = new ListViewItem();
                record.Text = player.currentPlaylist.Item[i].getItemInfo("Title");
                record.SubItems.Add(player.currentPlaylist.Item[i].durationString);               
                record.SubItems.Add(player.currentPlaylist.Item[i].getItemInfo("autor"));             
                record.SubItems.Add(player.currentPlaylist.Item[i].getItemInfo("album"));

                /*for (int j = 0; j < player.currentPlaylist.Item[0].attributeCount; j++)
                {
                    string attr = player.currentPlaylist.Item[i].getAttributeName(j);
                    listView1.Columns.Add(attr, attr, 50);
                    record.SubItems.Add(player.currentPlaylist.Item[i].getItemInfo(attr));
                }*/
                listView1.Items.Add(record);
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = trackBar2.Value;
            label1.Text = trackBar2.Value.ToString();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            player.controls.next();
        }
    }
}
