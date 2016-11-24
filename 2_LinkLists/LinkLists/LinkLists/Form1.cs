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

namespace LinkLists
{
    public partial class Form1 : Form
    {
        List<string> list = new List<string>();
        List<List<string>> link = new List<List<string>>();
        int selectList = -1;
        bool nsave = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadList("../../list.txt");
            for (int i = 0; i < list.Count; i++)
                comboBox1.Items.Add(list[i]);
        }

        void loadList(string file)
        {
            StreamReader read = new StreamReader(file);
            string count = read.ReadLine();
            int c = int.Parse(count);

            for (int i = 0; i < c; i++)
            {
                list.Add(read.ReadLine());
                loadLinks(i, "../../" + list[i] + ".txt");
            }

            read.Close();
        }

        void loadLinks(int n, string file)
        {
            try
            {
                StreamReader read = new StreamReader(file);
                string count = read.ReadLine();
                int c = int.Parse(count);
                List<string> l = new List<string>();

                for (int i = 0; i < c; i++)
                    l.Add(read.ReadLine());

                link.Add(l);
                read.Close();
            }
            catch (Exception e)
            {
                list.RemoveAt(n);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n = comboBox1.SelectedIndex;

            if (listBox1.Items.Count > 0 && selectList >= 0 && selectList != n)
            {
                int c = listBox1.Items.Count;
                link[selectList].RemoveAll(f => true);
                for (int i = 0; i < listBox1.Items.Count; i++)
                    link[selectList].Add(listBox1.Items[i].ToString());
            }

            selectList = n;
            listBox1.Items.Clear();

            
            if (n < list.Count)          
                for (int i = 0; i < link[n].Count; i++)
                    listBox1.Items.Add(link[n][i]);
                
        }
        // Удалить свойство
        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1)
            {
                link[comboBox1.SelectedIndex].RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                nsave = true;
            }      
        }
        // Добавить свойство
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                listBox1.Items.Add(textBox1.Text);
                link[comboBox1.SelectedIndex].Add(textBox1.Text);
                textBox1.Text = "";
                nsave = true;
            }                
        }
        // Удалить группу
        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                link.RemoveAt(comboBox1.SelectedIndex);
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);             
                listBox1.Items.Clear();
                nsave = true;
            }          
        }
        // Добавить группу
        private void button5_Click(object sender, EventArgs e)
        {
            if(textBox2.Text != "")
            {
                comboBox1.SelectedIndex = comboBox1.Items.Add(textBox2.Text);
                link.Add(new List<string>());
                list.Add(textBox2.Text);
                textBox2.Text = "";
                nsave = true;
            }              
        }
        // Сортировка
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Sorted = checkBox1.Checked;
        }
        // Сохранение
        private void button1_Click(object sender, EventArgs e)
        {
            if (nsave && MessageBox.Show("Вы действительно хотите сохранить списки?", "Сохранить?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                StreamWriter write = new StreamWriter("../../list.txt", false);
                write.WriteLine(list.Count);
                for (int i = 0; i < list.Count; i++)
                {
                    write.WriteLine(list[i]);
                    saveLinks(i, list[i]);
                }
                write.Close();
            }              
        }

        void saveLinks(int n, string file)
        {
            StreamWriter write = new StreamWriter("../../" + file + ".txt", false);
            write.WriteLine(link[n].Count);
            for (int i = 0; i < link[n].Count; i++)
                write.WriteLine(link[n][i]);
            write.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (nsave)
                if (MessageBox.Show("Сохранить списки перед выходом?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    button1_Click(null, new EventArgs());
        }
    }
}
