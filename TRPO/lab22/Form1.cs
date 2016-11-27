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

namespace lab22
{
    public partial class Form1 : Form
    {
        OleDbConnection c = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=lab22.mdb");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = sql_query(c, "SELECT * FROM audio");
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            for (int i = 1; i < 5; i++)
            {
                dataGridView1.Columns[i].HeaderText = Controls["label" + i].Text;
                Controls["textBox" + i].DataBindings.Add("Text", dataGridView1.DataSource, dt.Columns[i].ToString());
                Controls["textBox" + i].Tag = i;
            }
            dataGridView1.Columns[5].Visible = false;
            pictureBox1.DataBindings.Add("Image", dataGridView1.DataSource, "album_img", true);
            dataGridView1.Columns[6].HeaderText = "Сольный";
            checkBox1.DataBindings.Add("Checked", dataGridView1.DataSource, dt.Columns[6].ToString());
            dataGridView1.AutoResizeColumns();
            toolTip1.SetToolTip(addnew, "Добавление нового альбома");
            toolTip1.SetToolTip(delete, "Удаление не нового альбома");
            toolTip1.SetToolTip(save, "Иллюзия кнопки");
            toolTip1.SetToolTip(bNewPerf, "Создавайте авторов с умом");
            toolTip1.SetToolTip(change, "Дорога ложка к обеду");

        }      
        DataTable Fresh(string str = "SELECT * FROM audio")
        {
            DataTable dt = sql_query(c, str);
            dataGridView1.DataSource = dt;
            return dt;
        }

        private void addnew_Click(object sender, EventArgs e)
        {
            MemoryStream stream = new MemoryStream();
            pictureBox1.Image.Save(stream , System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] img = stream.ToArray();
            //if (sql_query(c, "INSERT INTO audio SET album_name='" + textBox1.Text + "', release_year=" + textBox2.Text + ", quantity_tracks=" + textBox3.Text + ", playing_time=" + textBox4.Text + ", album_img=@album_img", "@album_img", img) > 0)
            if (sql_query(c, "INSERT INTO audio( album_name, release_year, quantity_tracks, playing_time, album_img)  VALUES('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', @album_img)", "@album_img", img) > 0)
                MessageBox.Show("Запись успешно добавлена.");
            Fresh();
        }

        DataTable sql_query(OleDbConnection c, string query)
        {
            DataTable dt = new DataTable();
            OleDbCommand mc = new OleDbCommand();
            OleDbDataAdapter da = new OleDbDataAdapter();
            c.Open();
            mc.Connection = c;
            mc.CommandText = query;
            da.SelectCommand = mc;
			try
			{
				da.Fill(dt);
			}
            catch(Exception e) { MessageBox.Show(e.Message); }
            c.Close();
            return dt;
        }
        void sql_query(OleDbConnection c, string query, out object t)
        {
            DataTable dt = new DataTable();
            OleDbCommand mc = new OleDbCommand();
            OleDbDataAdapter da = new OleDbDataAdapter();
            c.Open();
            mc.Connection = c;
            mc.CommandText = query;
            da.SelectCommand = mc;
            da.Fill(dt);
            c.Close();
            t = (object)dt.Rows[0][0];
        }

        int sql_query(OleDbConnection c, string query, string simg = null, byte[] img = null)
        {
            int n = 0;
            DataTable dt = new DataTable();
            OleDbCommand mc = new OleDbCommand();
            OleDbDataAdapter da = new OleDbDataAdapter();
            c.Open();
            mc.Connection = c;
            mc.CommandText = query;
            if (simg != null && img !=null || simg != "add")
            mc.Parameters.AddWithValue(simg, img);
            n = mc.ExecuteNonQuery();
            c.Close();
            return n;
        }

        private void change_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = Image.FromFile(ofd.FileName);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DataTable dt = sql_query(c, " SELECT performer.id, performer.perf_name, performer.style, performer.country FROM Disc, performer WHERE Disc.id_perf =  performer.id and Disc.id = " + id);
            comboBox1.Items.Clear();
            for (int j = 0; j < dt.Rows.Count; j++)
            {
                string str = dt.Rows[j][1].ToString();
                comboBox1.Items.Add(str);
            }
            //Text = dt.Rows[0][0].ToString();
        }
                
        private void textBox0_TextChanged(object sender, EventArgs e)
        {
            /**/
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dts = sql_query(c, "SELECT country, style FROM performer WHERE perf_name='" + comboBox1.SelectedItem.ToString() + "'");
            textBox5.Text = dts.Rows[0][1].ToString();
            textBox6.Text = dts.Rows[0][0].ToString();

            object t;
            sql_query(c, "Select max(id) from performer", out t);
        }

        private void bNewPerf_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.ToString() == "" || textBox5.Text == "" || textBox6.Text == "")
                return;
           if(sql_query(c, "Insert into performer(perf_name, style, country) values('" + comboBox1.Text.ToString() + "', '" + textBox5.Text + "', '" + textBox6.Text +"') ", "add") > 0)
                MessageBox.Show("Запись успешно добавлена.");
            object t;
            sql_query(c, "Select max(id) from performer", out t);
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (sql_query(c, "Insert into Disc values(" + id + "," + t + ")", "add") > 0)
                MessageBox.Show("Запись успешно добавлена.");

            
        }



        private void textBox1_TextChanged(object sender, KeyEventArgs e)
        {
            TextBox tx = (TextBox)sender;
           string str = Fresh().Columns[(int)tx.Tag].ToString();
            if ((int)tx.Tag == 1)
       //     Fresh("Select * from audio where lower(" + str + ") like lower('%" + tx.Text + "%')");
            Fresh("Select * from audio where lcase(" + str + ") like lcase('%" + tx.Text + "%')");
            
            //  Fresh("Select * from audio where lower("+ str +") like lower('%"+tx.Text + "%')");
            else
              Fresh("Select * from audio where " + str + " = " + tx.Text);
            Text = tx.Text;

        }

        private void save_Click(object sender, EventArgs e)
        {
            Fresh();
        }
    }



}

