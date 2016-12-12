using System;
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
	public partial class Audio : Form
	{
		OleDbConnection DBC;

		public Audio(OleDbConnection DBC)
		{
			this.DBC = DBC;
			InitializeComponent();
		}
		// Загрузка таблицы
		private void Audio_Load(object sender, EventArgs e)
		{
			DataTable dt = SQL.query(DBC, "SELECT audio.[code] AS Код, audio.[name_audio] AS Название, audio.[years] AS Год, "
				+ "audio.[tracks] AS [Кол-во треков], audio.[time] AS [Время звучания], audio.[img], audio.[solo] AS [Сольный] FROM audio; ");
			dataGridView1.DataSource = dt;
			dataGridView1.Columns[5].Visible = false;
            for (int i = 1; i < 5; i++)
			{
				Controls["textBox" + i].DataBindings.Add("Text", dataGridView1.DataSource, dt.Columns[i].ToString());
				Controls["textBox" + i].Tag = i;
			}
			pictureBox1.DataBindings.Add("Image", dataGridView1.DataSource, "album_img", true);
			checkBox1.DataBindings.Add("Checked", dataGridView1.DataSource, dt.Columns[6].ToString());
			dataGridView1.AutoResizeColumns();
		}
		// Фильтр
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox tx = (TextBox)sender;
            DataTable fdt = SQL.query(DBC, "SELECT audio.[code] AS Код, audio.[name_audio] AS Название, audio.[years] AS Год, "
                + "audio.[tracks] AS [Кол-во треков], audio.[time] AS [Время звучания], audio.[img], audio.[solo] AS [Сольный] FROM audio where lcase(audio.[name_audio]) like lcase('%" + tx.Text + " %') ; ");
            dataGridView1.DataSource = fdt;

        }

		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void AddRecord_Click(object sender, EventArgs e)
		{
			AddAudio addaudio = new AddAudio(DBC);
			addaudio.Show();
		}
	}
}
