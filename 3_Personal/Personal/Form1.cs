using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Выбора записи
        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            button3.Enabled = true;
            button2.Enabled = false;
            label2.Visible = false;
            textBox1.Visible = false;
        }
        // Выбор действия
        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button3.Enabled = false;
            label2.Visible = true;
            textBox1.Visible = true;
        }
        // Добавить запись
        private void button2_Click(object sender, EventArgs e)
        {
            
            ListViewItem item1 = new ListViewItem();
            item1.Text = textBox1.Text;
            item1.SubItems.Add(radioButton1.Checked ? radioButton1.Text : radioButton2.Text);
            foreach(RadioButton n in groupBox2.Controls)
            {
                if (n.Checked)
                    item1.SubItems.Add("1");
                else
                    item1.SubItems.Add("0");
            }
            if(checkBox1.Checked)
                item1.SubItems.Add("1");
            else
                item1.SubItems.Add("0");
            item1.SubItems.Add(comboBox1.Text);
            bool t = true;
            for (int n = 0; n < comboBox1.Items.Count; n++)
                if (comboBox1.Items[n].ToString() == comboBox1.Text)
                    t = false;
            if(t)
                comboBox1.Items.Add(comboBox1.Text);
            item1.SubItems.Add("");
            listView1.Items.Add(item1);
        }
        // Очистить поля
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            comboBox1.Text = "";
            checkBox1.Checked = false;
            radioButton1.Checked = true;
            radioButton3.Checked = true;
        }
        // Очистить таблицу
        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            listView1.Items.Clear();
        }
        // Выбрать подходящих
        private void button3_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < listView1.Items.Count; i++)
            {
                listView1.Items[i].SubItems[9].Text = "";
                ListViewItem k = listView1.Items[i];
                if (k.SubItems[1].Text != groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text)
                    continue;
                var inv = groupBox2.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                var str = k.SubItems[int.Parse((string)inv.Tag)].Text;
                if (str != "1")
                    continue;
                if(checkBox1.Checked && k.SubItems[7].Text != "1")
                    continue;
                if(k.SubItems[8].Text != comboBox1.Text)
                    continue;
                listView1.Items[i].SubItems[9].Text = "кандидат";
            }
        }
    }
}
