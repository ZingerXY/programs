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
	public partial class Authors : Form
	{
		OleDbConnection DBC;
        DataTable dt2;

        public Authors(OleDbConnection DBC)
		{
			this.DBC = DBC;
			InitializeComponent();
		}

		private void Authors_Load(object sender, EventArgs e)
		{
			update_dataGridView();
		}

		private void update_dataGridView()
		{
			//1 знак - автор + 99 стилей + 99 стран + 999 групп
			dt2 = SQL.query(DBC,
				"SELECT (authors.code + 20000024 + style.code * 100000 + country.code * 1000) as Код, authors.group_name AS Группа, " +
				"style.style_name AS Стиль, country.country_name AS Страна FROM style INNER JOIN(country INNER JOIN authors " +
				"ON country.[code] = authors.[country]) ON style.[code] = authors.[style];");
			dataGridView1.DataSource = dt2;
		}

		private void Add_Click(object sender, EventArgs e)
		{
			List<string[]> ls = new List<string[]>();
			ls.Add("group_name,Название группы".Split(','));
			ls.Add("style,Стиль,style".Split(','));
			ls.Add("country,Страна,country".Split(','));
			Insert ins = new Insert("authors", ls);
			Add add = new Add(DBC, ins, update_dataGridView);
			add.Show();
		}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox tx = (TextBox)sender;
            string str = tx.Tag.ToString();

            if (tx.Tag.ToString() != "")
            {
                str = "SELECT (authors.code + 20000024 + style.code * 100000 + country.code * 1000) as Код, authors.group_name " +
					"AS Группа, style.style_name AS Стиль, country.country_name AS Страна FROM style INNER JOIN(country INNER JOIN " +
					"authors ON country.[code] = authors.[country]) ON style.[code] = authors.[style] where lcase(" + tx.Tag.ToString() + 
					") like lcase ('%" + tx.Text + "%')";
                dt2 = SQL.query(DBC, str);
                dataGridView1.DataSource = dt2;

            }

        }
    }
}
