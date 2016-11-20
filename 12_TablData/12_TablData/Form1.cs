using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_TablData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class tovar
        {
            public string name { get; set; }
            string category { get; set; }
            int balance { get; set; }
            int cost { get; set; }
            int year { get; set; }

            public tovar(string name, string category, int balance, int cost, int year)
            {
                this.name = name;
                this.category = category;
                this.balance = balance;
                this.cost = cost;
                this.year = year;
            }

            public tovar(string[] arr)
            {
                this.name = arr[0];
                this.category = arr[1];
                this.balance = int.Parse(arr[2]);
                this.cost = int.Parse(arr[3]);
                this.year = int.Parse(arr[4]);
            }

            public string getStr()
            {
                return name+"\t"+category+"\t"+balance+"\t"+cost+"\t"+year;
            }
        }

        List<tovar> list = new List<tovar>();

        void loadList(string file)
        {
            StreamReader read = new StreamReader(file);
            string count = read.ReadLine();
            int c = int.Parse(count);
            listView1.Items.Clear();
            list.Clear();

            for (int i = 0; i < c; i++)
            {
                string str = read.ReadLine();
                string[] arr = str.Split('\t');
                ListViewItem item1 = new ListViewItem();
                item1.Text = arr[0];
                for(int j = 1; j < arr.Length; j++)
                    item1.SubItems.Add(arr[j]);
                listView1.Items.Add(item1);
                tovar t = new tovar(arr[0], arr[1], int.Parse(arr[2]), int.Parse(arr[3]), int.Parse(arr[4]));
                list.Add(t);
            }

            read.Close();
        }

        void updateListView()
        {
            listView1.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                ListViewItem item1 = new ListViewItem();
                item1.Text = list[i].name;
                string[] arr = list[i].getStr().Split('\t');
                for (int j = 1; j < arr.Length; j++)
                    item1.SubItems.Add(arr[j]);
                listView1.Items.Add(item1);
            }
        }

        void saveList(string file)
        {
            StreamWriter write = new StreamWriter(file, false);
            write.WriteLine(list.Count);
            for(int i = 0; i < list.Count; i++)
                write.WriteLine(list[i].getStr());
            write.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadList("tovar.txt");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
                loadList(f.FileName);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
                saveList(f.FileName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] arr = new string[5];
            for (int n = 0; n < 5; n++)
            {
                arr[n] = Controls["textBox" + (n + 1)].Text;
                Controls["textBox" + (n + 1)].Text = "";
            }
                
            list.Add(new tovar(arr));
            updateListView();
        }
    }
}
