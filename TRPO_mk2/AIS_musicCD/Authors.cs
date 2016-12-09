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

		public Authors(OleDbConnection DBC)
		{
			this.DBC = DBC;
			InitializeComponent();
		}

		private void Authors_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = SQL.query(DBC,
				"SELECT style.code AS Код, authors.group_name AS Группа, style.style_name AS Стиль, country.country_name AS Страна " +
				" FROM style INNER JOIN (country INNER JOIN authors ON country.[code] = authors.[country]) ON style.[code] = authors.[style];");
		}

		private void Add_Click(object sender, EventArgs e)
		{
			
		}
	}
}
