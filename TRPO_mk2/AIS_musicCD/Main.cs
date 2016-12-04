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
	public partial class Main : Form
	{
		OleDbConnection DBC = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=AIS.mdb");

		public Main()
		{
			InitializeComponent();
		}

		private void Audio_Click(object sender, EventArgs e)
		{
			Audio audio = new Audio(DBC);
			audio.Show();
		}

		private void Autors_Click(object sender, EventArgs e)
		{
			Autors autors = new Autors(DBC);
			autors.Show();
		}

		private void Style_Click(object sender, EventArgs e)
		{
			Style style = new Style(DBC);
			style.Show();
		}

		private void Country_Click(object sender, EventArgs e)
		{
			Country country = new Country(DBC);
			country.Show();
		}

		private void Report_Click(object sender, EventArgs e)
		{
			Report report = new Report(DBC);
			report.Show();
		}
	}
}
