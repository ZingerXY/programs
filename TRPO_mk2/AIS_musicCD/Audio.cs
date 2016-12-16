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
			update_dataGridView();
        }

		private void update_dataGridView()
		{
			dataGridView1.DataSource = SQL.query(DBC, "SELECT audio.[code] AS Код, audio.[name_audio] AS Название, audio.[years] AS Год, "
				+ "audio.[tracks] AS [Кол-во треков], audio.[time] AS [Время звучания], audio.[img], audio.[solo] AS [Сольный] FROM audio; ");
			dataGridView1.Columns[5].Visible = false;
			pictureBox1.DataBindings.Clear();
			pictureBox1.DataBindings.Add("Image", dataGridView1.DataSource, "img", true);

			string code = dataGridView1.CurrentRow.Cells[0].Value.ToString();
			dataGridView2.DataSource = SQL.query(DBC, "SELECT (authors.code + 20000024 + style.code * 100000 + country.code * 1000) as Код, authors.group_name AS Группа, " +
				"style.style_name AS Стиль, country.country_name AS Страна FROM [connect], style INNER JOIN(country INNER JOIN authors " +
				"ON country.[code] = authors.[country]) ON style.[code] = authors.[style] WHERE [connect].[code_author] = [authors].[code] AND [connect].[code_audio] = " + code);
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
			AddAudio addaudio = new AddAudio(DBC, update_dataGridView);
			addaudio.Show();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			string code = dataGridView1.CurrentRow.Cells[0].Value.ToString();
			DataTable dt = SQL.query(DBC, "SELECT (authors.code + 20000024 + style.code * 100000 + country.code * 1000) as Код, authors.group_name AS Группа, " +
				"style.style_name AS Стиль, country.country_name AS Страна FROM [connect], style INNER JOIN(country INNER JOIN authors " +
				"ON country.[code] = authors.[country]) ON style.[code] = authors.[style] WHERE [connect].[code_author] = [authors].[code] AND [connect].[code_audio] = " + code);			
			dataGridView2.DataSource = dt;
		}

		private void Delete_Click(object sender, EventArgs e)
		{
			string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
			if (MessageBox.Show("Вы действительно хотите удалить запись?.", "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
				if (SQL.query(DBC, "DELETE * FROM audio WHERE code = " + id, "add") > 0)
				{
					update_dataGridView();
					MessageBox.Show("Запись успешно удалена.");
				}
		}

		private void Update_Click(object sender, EventArgs e)
		{
			string[] str = new string[5];
			for (int i = 0; i < 5; i++)
				str[i] = dataGridView1.CurrentRow.Cells[i].Value.ToString();
			bool solo = (bool)dataGridView1.CurrentRow.Cells[6].Value;
            UpdateAudio updateaudio = new UpdateAudio(DBC, update_dataGridView, str, solo, pictureBox1.Image);
			updateaudio.Show();
		}
	}
}
