using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_TablData
{
    public partial class Form2 : Form
    {
        List<tovar> list;
        string category;

        public Form2(string category, List<tovar> list)
        {
            InitializeComponent();
            this.list = list;
            this.category = category;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Text = "Категория товаров: " + category;
            updateListView();
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
    }
}
