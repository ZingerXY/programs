using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
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
		Action update;

		Dictionary<int, string> record = new Dictionary<int, string>();
		Dictionary<int, string> addrecord = new Dictionary<int, string>();

		public AddAudio(OleDbConnection DBC, Action update)
		{
			this.DBC = DBC;
			this.update = update;
			InitializeComponent();           
        }

		private void AddAudio_Load(object sender, EventArgs e)
		{
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
			record.Clear();
			addrecord.Clear();
			comboBox1.Items.Clear();
            listBox1.Items.Clear();
            dt = SQL.query(DBC, "SELECT code, group_name FROM authors");
            for (int j = 0; j < dt.Rows.Count; j++)
            {
				string code = dt.Rows[j][0].ToString();
				string name = dt.Rows[j][1].ToString();
				record.Add(comboBox1.Items.Add(name), code);
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
            int index = listBox1.Items.Add(comboBox1.SelectedItem.ToString());
			addrecord.Add(index, record[comboBox1.SelectedIndex]);
			record.Remove(comboBox1.SelectedIndex);
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

		private void Add_Click(object sender, EventArgs e)
		{
			bool test = true;
			for (int i = 1; i < 5; i++)
			{
				if (Controls["textBox" + i].Text == "")
					test = false;
			}
			if (!test)
			{
				MessageBox.Show("Не все поля заполнены.");
				return;
			}
			if(listBox1.Items.Count < 1)
			{
				MessageBox.Show("Не выбрано ни одного автора.");
				return;
			}
			if(pictureBox1.Image == null)
			{
				MessageBox.Show("Не выбрано изображение.");
				return;
			}
			MemoryStream stream = new MemoryStream();
			pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
			byte[] img = stream.ToArray();
			//if (sql_query(c, "INSERT INTO audio SET album_name='" + textBox1.Text + "', release_year=" + textBox2.Text + ", quantity_tracks=" + textBox3.Text + ", playing_time=" + textBox4.Text + ", album_img=@album_img", "@album_img", img) > 0)
			if (SQL.query(DBC, "INSERT INTO audio(name_audio, years, tracks, [time], img, solo)  VALUES('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', @album_img, '"+ (checkBox1.Checked ? -1 : 0) +"')", "@album_img", img) > 0)
			{
				object t;
				bool res = true;
				SQL.query(DBC, "SELECT MAX(code) FROM audio", out t);
				foreach(var i in addrecord)
					res = res && (SQL.query(DBC, "INSERT INTO [connect](code_audio, code_author) VALUES('" + t.ToString() + "','" + i.Value + "')", "add") > 0);
				if(res)
				{
					update();
					MessageBox.Show("Запись успешно добавлена.");
				}					
				Close();
			}				
		}		
	}
}
