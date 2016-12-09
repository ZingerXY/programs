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
            //1 знак - автор + 99 стилей + 99 стран + 999 групп
            DataTable dt2 = SQL.query(DBC,
"SELECT (authors.code + 20000024 + style.code * 100000 + country.code * 1000) as Код, authors.group_name AS Группа, style.style_name AS Стиль, country.country_name AS Страна FROM style INNER JOIN(country INNER JOIN authors ON country.[code] = authors.[country]) ON style.[code] = authors.[style];");
            dataGridView1.DataSource = dt2;
        }
		private void Add_Click(object sender, EventArgs e)
		{
			
		}
	}
}
