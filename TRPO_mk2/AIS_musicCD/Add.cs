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
	public partial class Add : Form
	{
		OleDbConnection DBC;

		public Add(OleDbConnection DBC)
		{
			this.DBC = DBC;
			InitializeComponent();
		}

		private void Add_Load(object sender, EventArgs e)
		{

		}
	}
}
