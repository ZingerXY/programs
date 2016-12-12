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
	public partial class AddAudio : Form
	{
		OleDbConnection DBC;

		public AddAudio(OleDbConnection DBC)
		{
			this.DBC = DBC;
			InitializeComponent();
		}

		private void change_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			if (ofd.ShowDialog() == DialogResult.OK)
				pictureBox1.Image = Image.FromFile(ofd.FileName);
		}
	}
}
