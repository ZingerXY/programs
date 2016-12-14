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
            comboBox1.Items.Clear();
            listBox1.Items.Clear();
            dt = SQL.query(DBC, "Select authors.group_name, code from authors");
            for (int j = 0; j < dt.Rows.Count; j++)
            {
                string str = dt.Rows[j][0].ToString();
                comboBox1.Items.Add(str);
            }

        }

        private void AddAuthor_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && listBox1.Items.Count > 0)
            {
                MessageBox.Show("В сольный альбом нельзя добавить больше одного исполнителя");
                return;

            }

            if (comboBox1.SelectedIndex == -1)
                return;
            listBox1.Items.Add(comboBox1.SelectedItem.ToString());
            comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                authors_combobox();
            }

        }

        private void NewAuthor_Click(object sender, EventArgs e)
        {
            List<string[]> ls = new List<string[]>();
            ls.Add("group_name,Название группы".Split(','));
            ls.Add("style,Стиль,style".Split(','));
            ls.Add("country,Страна,country".Split(','));
            Insert ins = new Insert("authors", ls);
            Add add = new Add(DBC, ins, authors_combobox);
            add.Show();

        }

        private void AddAudio_Activated(object sender, EventArgs e)
        {
            Text = "Окно активно!";
        }
    }
}
