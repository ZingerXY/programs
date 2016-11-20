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

        List<tovar> list = new List<tovar>();
        List<tovar> buy = new List<tovar>();

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
                tovar t = new tovar(arr);
                list.Add(t);
            }

            updateListView(listView1, list);
            read.Close();
        }

        void updateListView(ListView listview, List<tovar> tov)
        {
            listview.Items.Clear();
            for (int i = 0; i < tov.Count; i++)
            {
                bool ch = true;
                ListViewItem item1 = new ListViewItem();
                item1.Text = tov[i].name;
                string[] arr = tov[i].getStr().Split('\t');
                for (int j = 0; j < comboBox1.Items.Count; j++)
                    if(comboBox1.Items[j].ToString() == arr[1])
                        ch = false;
                if (ch)
                    comboBox1.Items.Add(arr[1]);
                for (int j = 1; j < arr.Length; j++)
                    item1.SubItems.Add(arr[j]);
                listview.Items.Add(item1);
            }
        }

        void saveList(string file, List<tovar> tov)
        {
            StreamWriter write = new StreamWriter(file, false);
            write.WriteLine(tov.Count);
            for(int i = 0; i < tov.Count; i++)
                write.WriteLine(tov[i].getStr());
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
                saveList(f.FileName, list);
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
            updateListView(listView1, list);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0) return;
            List<tovar> l = new List<tovar>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].category != (string)comboBox1.SelectedItem) continue;
                l.Add(list[i]);
            }

            Form2 f2 = new Form2((string)comboBox1.SelectedItem, l);
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i].recalculation();
            }
            updateListView(listView1, list);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Ничего не выбрано");
                return;
            }
            int count;
            if(!int.TryParse(textBox6.Text,out count))
            {
                MessageBox.Show("Введите количество");
                return;
            }
            if(count > list[listView1.SelectedIndices[0]].balance)
            {
                MessageBox.Show("Не достаточно товара на складе");
                return;
            }
            tovar temp = list[listView1.SelectedIndices[0]];
            int balance = list[listView1.SelectedIndices[0]].balance - count;
            temp.balance = count;
            buy.Add(new tovar(temp.getStr().Split('\t')));        
            list[listView1.SelectedIndices[0]].balance = balance;
            updateListView(listView2, buy);
            updateListView(listView1, list);
            int allcost = 0;
            for (int i = 0; i < buy.Count; i++)
                allcost += buy[i].getAllCost();
            label9.Text = allcost.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
                saveList(f.FileName, buy);
        }
    }

    public class tovar
    {
        public string name { get; set; }
        public string category { get; set; }
        public int balance { get; set; }
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

        public int getAllCost()
        {
            return cost * balance;
        }

        public string getStr()
        {
            return name + "\t" + category + "\t" + balance + "\t" + cost + "\t" + year;
        }

        public void recalculation()
        {
            if(DateTime.Now.Year - year > 5)
            {
                year = DateTime.Now.Year;
                cost = cost / 2;
            }
        }
    }
}
