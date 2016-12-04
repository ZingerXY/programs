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

		private void Audio_Load(object sender, EventArgs e)
		{
			DataTable dt = SQL.query(DBC, "SELECT * FROM audio");
			dataGridView1.DataSource = dt;
			for (int i = 1; i < 5; i++)
			{
				dataGridView1.Columns[i].HeaderText = Controls["label" + i].Text;
				Controls["textBox" + i].DataBindings.Add("Text", dataGridView1.DataSource, dt.Columns[i].ToString());
				Controls["textBox" + i].Tag = i;
			}
			pictureBox1.DataBindings.Add("Image", dataGridView1.DataSource, "album_img", true);
			dataGridView1.Columns[6].HeaderText = "Сольный";
			checkBox1.DataBindings.Add("Checked", dataGridView1.DataSource, dt.Columns[6].ToString());
			dataGridView1.AutoResizeColumns();
		}
	}
}
