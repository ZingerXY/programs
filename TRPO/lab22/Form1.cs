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
            }
            dataGridView1.Columns[5].Visible = false;
            pictureBox1.DataBindings.Add("Image", dataGridView1.DataSource, "album_img", true);
            dataGridView1.Columns[6].HeaderText = "Сольный";
            checkBox1.DataBindings.Add("Checked", dataGridView1.DataSource, dt.Columns[6].ToString());
            dataGridView1.AutoResizeColumns();
        }

        private void addnew_Click(object sender, EventArgs e)
        {
            MemoryStream stream = new MemoryStream();
            pictureBox1.Image.Save(stream , System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] img = stream.ToArray();
            //if (sql_query(c, "INSERT INTO audio SET album_name='" + textBox1.Text + "', release_year=" + textBox2.Text + ", quantity_tracks=" + textBox3.Text + ", playing_time=" + textBox4.Text + ", album_img=@album_img", "@album_img", img) > 0)
            if (sql_query(c, "INSERT INTO audio( album_name, release_year, quantity_tracks, playing_time, album_img) VALUES('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', @album_img)", "@album_img", img) > 0)
                MessageBox.Show("Запись успешно добавлена.");
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
            da.Fill(dt);
            c.Close();
            return dt;
        }

        int sql_query(OleDbConnection c, string query, string simg, byte[] img)
        {
            int n = 0;
            DataTable dt = new DataTable();
            OleDbCommand mc = new OleDbCommand();
            OleDbDataAdapter da = new OleDbDataAdapter();
            c.Open();
            mc.Connection = c;
            mc.CommandText = query;
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
            DataTable dt = sql_query(c, "SELECT * FROM Disc WHERE id=" + id);
            /*
                SELECT performer.id, performer.perf_name, performer.style, performer.country 
                FROM Disc, performer
                WHERE Disc.id =  AND performer.id = Disc.id_perf
             */
            comboBox1.Items.Clear();
            for (int j = 0; j < dt.Rows.Count; j++)
            {
                id = dt.Rows[1][j].ToString();
                DataTable dtb = sql_query(c, "SELECT * FROM performer WHERE id=" + id);
                string str = dtb.Rows[0][0].ToString();
                comboBox1.Items.Add(str);
            }
            //Text = dt.Rows[0][0].ToString();
        }




        private void textBox0_TextChanged(object sender, EventArgs e)
        {
            /**/
        }
    }
}
