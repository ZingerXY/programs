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
        DataTable dt;


        public AddAudio(OleDbConnection DBC)
		{
			this.DBC = DBC;
			InitializeComponent();
            authors_combobox();

        }

		private void change_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			if (ofd.ShowDialog() == DialogResult.OK)
				pictureBox1.Image = Image.FromFile(ofd.FileName);
		}

        //Добавляем авторов в комбобокс и в листбокс
        private void authors_combobox()
        {
            dt = SQL.query(DBC, "Select authors.group_name from authors");
            for (int j = 0; j < dt.Rows.Count; j++)
            {
                string str = dt.Rows[j][0].ToString();
                comboBox1.Items.Add(str);
                listBox1.Items.Add(str);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = listBox1.SelectedIndex;
        }
    }
}
