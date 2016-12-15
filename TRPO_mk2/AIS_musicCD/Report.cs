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
	public partial class Report : Form
	{
		OleDbConnection DBC;

		public Report(OleDbConnection DBC)
		{
			this.DBC = DBC;
			InitializeComponent();
		}

		private void ShowReport()
		{
			int sol = 20;
			int gr = 50;
			chart1.Titles.Add("Сольные записи и сборники");
			chart1.Series[0].Points.AddY(sol);
			chart1.Series[0].Points[0].Label = sol + " Сольные";
			chart1.Series[0].Points.AddY(gr);
			chart1.Series[0].Points[1].Label = gr + " Cборники";

			int clasic = 10;
			int rock = 20;
			chart2.Titles.Add("Стили");
			chart2.Series[0].Points.AddXY("Класика", clasic);
			chart2.Series[0].Points.AddXY("Рок", rock);
        }

		private void Report_Load(object sender, EventArgs e)
		{
			ShowReport();
        }
	}
}
