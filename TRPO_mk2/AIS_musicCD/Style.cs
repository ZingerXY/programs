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
	public partial class Style : Form
	{
		OleDbConnection DBC;

		public Style(OleDbConnection DBC)
		{
			this.DBC = DBC;
			InitializeComponent();
		}

		private void Style_Load(object sender, EventArgs e)
		{
			update_dataGridView();
        }

		private void update_dataGridView()
		{
			DataTable dt = SQL.query(DBC, "SELECT style.[code] AS Код, style.[style_name] AS Стиль FROM style; ");
		}

		private void AddNew_Click(object sender, EventArgs e)
		{
			string[]  str = new string[2];
			str = "style_name Стиль".Split(' ');
			Insert ins = new Insert("style", str);
			Add add = new Add(DBC, ins);
			add.Show();
			/*if (SQL.query(DBC, "INSERT INTO style(style_name) VALUES('" + textBox1.Text + "')", "add") > 0)
			{
				dataGridView1.DataSource = SQL.query(DBC, "SELECT * FROM style");
				textBox1.Text = "";
				MessageBox.Show("Стиль " + textBox1.Text + " успешно добавлен.");				
			}*/
		}
	}
}
