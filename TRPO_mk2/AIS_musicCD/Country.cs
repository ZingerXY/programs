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
	public partial class Country : Form
	{
		OleDbConnection DBC;

		public Country(OleDbConnection DBC)
		{
			this.DBC = DBC;
			InitializeComponent();
		}

		private void Country_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = SQL.query(DBC, "SELECT * FROM country");
			dataGridView1.Columns[0].HeaderText = "Код";
			dataGridView1.Columns[1].HeaderText = "Страна";
			dataGridView1.AutoResizeColumns();
		}

		private void AddNew_Click(object sender, EventArgs e)
		{
			string[] str = new string[2];
			str = "country_name Страна".Split(' ');
			Insert ins = new Insert("country", str);
			Add add = new Add(DBC, ins);
			add.Show();
			/*if (SQL.query(DBC, "INSERT INTO country(country_name) VALUES('" + textBox1.Text + "')", "add") > 0)
			{
				textBox1.Text = "";
				dataGridView1.DataSource = SQL.query(DBC, "SELECT * FROM country");
				MessageBox.Show("Страна "+ textBox1.Text + " успешно добавлена.");
            }	*/
		}
	}
}
