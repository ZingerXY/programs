﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIS_musicCD
{
	public partial class Main : Form
	{
		OleDbConnection DBC = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=AIS.mdb");
        private Point mouseOffset;
        private bool isMouseDown = false;

        public Main()
		{
			InitializeComponent();
		}

		private void Audio_Click(object sender, EventArgs e)
		{
			Audio audio = new Audio(DBC);
			audio.Show();
		}

		private void Authors_Click(object sender, EventArgs e)
		{
			Authors authors = new Authors(DBC);
			authors.Show();
		}

		private void Style_Click(object sender, EventArgs e)
		{
			Style style = new Style(DBC);
			style.Show();
		}

		private void Country_Click(object sender, EventArgs e)
		{
			Country country = new Country(DBC);
			country.Show();
		}

		private void Report_Click(object sender, EventArgs e)
		{
			Report report = new Report(DBC);
			report.Show();
		}
        private void Move_Click(object sender, EventArgs e)
        {
            Move move = new AIS_musicCD.Move(DBC);
            move.Show();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Start();
            timer.Interval = 1000;
            timer.Tick += tikaet;
            label2.Text = "Сегодня: " + DateTime.Now.ToString();
			ToolTip tt = new ToolTip();
			tt.SetToolTip(Audio, "Просмотр и добавление дисков");
			tt.SetToolTip(Authors, "Просмотр и добавление авторов");
			tt.SetToolTip(Style, "Просмотр и добавление стилей");
			tt.SetToolTip(Country, "Просмотр и добавление стран");
			//label2.BackColor = Color.FromArgb(120, 150, 150, 150);
		}

        private void tikaet(object sender, EventArgs e)
        {
         //   throw new NotImplementedException();
            label2.Text = "Сегодня: " + DateTime.Now.ToString();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;
            int yOffset;

            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
                yOffset = -e.Y - SystemInformation.CaptionHeight -
                    SystemInformation.FrameBorderSize.Height;
                mouseOffset = new Point(xOffset, yOffset);
                isMouseDown = true;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X + 4, mouseOffset.Y + 26);
                Location = mousePos;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

		private void button1_Click(object sender, EventArgs e)
		{
			Close();
		}

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
