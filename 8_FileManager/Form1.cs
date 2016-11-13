using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Explorer
{
    public partial class Form1 : Form
    {
        string path = @"C:";
        DriveInfo[] drive = DriveInfo.GetDrives();
  
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            megafunction();
            label1.Text = path;
            for (int i = 0; i < drive.Length; i++)
                comboBox1.Items.Add(drive[i].Name);
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            string n = listBox1.Text;
            path += @"\" + n.Remove(0, 2);

            label1.Text = path;
            megafunction();

        }

        void megafunction()
        {
            listView1.Items.Clear();
            DirectoryInfo x = new DirectoryInfo(path + @"\");
            DirectoryInfo[] dirs = null;
            FileInfo[] files = null;
            try
            {
                dirs = x.GetDirectories();
            }
            catch (Exception e)
            {
                button1_Click(null, null);
                return;
            }

            try
            {
                files = x.GetFiles();
            }
            catch (Exception e)
            {
                button1_Click(null, null);
                return;
            }

            for (int i = 0; i < dirs.Length; i++)
            {
                listView1.Items.Add("> " + dirs[i].Name);
                
            }
            for (int i = 0; i < files.Length; i++)
            {
                listView1.Items.Add(files[i].Name);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            int x = path.LastIndexOf('\\');
            if (x == -1)
            {
                return;
            }
            path = path.Remove(x);

            label1.Text = path;
            megafunction();
        }

   /*     private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string n = listView1.Text;
            path += @"\" + n.Remove(0, 2);

            label1.Text = path;
            megafunction();
        } */

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            string n = listView1.SelectedItems[0].Text;
            path += @"\" + n.Remove(0, 2);
            label1.Text = path;
            megafunction();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1) return;
            Form2 info = new Form2();
            info.param = comboBox1.Text;
            info.Show();
        }
    }
}