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
			dataGridView1.DataSource = SQL.query(DBC, "SELECT style.[code] AS [Код], style.[style_name] AS [Стиль] FROM style; ");
		}

		private void AddNew_Click(object sender, EventArgs e)
		{
			string[]  str = new string[2];
			str = "style_name Стиль".Split(' ');
			Insert ins = new Insert("style", str);
			Add add = new Add(DBC, ins, update_dataGridView);
			add.Show();
			/*if (SQL.query(DBC, "INSERT INTO style(style_name) VALUES('" + textBox1.Text + "')", "add") > 0)
			{
				dataGridView1.DataSource = SQL.query(DBC, "SELECT * FROM style");
				textBox1.Text = "";
				MessageBox.Show("Стиль " + textBox1.Text + " успешно добавлен.");				
			}*/
		}

		private void Update_Click(object sender, EventArgs e)
		{
			string[] str = new string[3];
			str = ("style_name Стиль " + dataGridView1.CurrentRow.Cells[1].Value.ToString()).Split(' ');
			Update ins = new Update("style", dataGridView1.CurrentRow.Cells[0].Value.ToString(), str);
			Up up = new Up(DBC, ins, update_dataGridView);
			up.Show();
		}

		private void Delete_Click(object sender, EventArgs e)
		{
			DataTable dt = SQL.query(DBC, "SELECT * FROM authors WHERE style = " + dataGridView1.CurrentRow.Cells[0].Value.ToString());
			if (dt.Rows.Count > 0)
			{
				MessageBox.Show("Этот стиль испольуется в таблице Авторы.","Нарушение целостности");
				return;
			}
			if (MessageBox.Show("Вы действительно хотите удалить запись?.", "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
				if (SQL.query(DBC, "DELETE * FROM style WHERE code = " + dataGridView1.CurrentRow.Cells[0].Value.ToString(), "add") > 0)
				{
					update_dataGridView();
					MessageBox.Show("Запись успешно удалена.");
				}
		}
	}
}
