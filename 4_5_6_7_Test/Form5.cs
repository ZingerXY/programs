using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTestProfi
{
    public partial class Form5 : Form
    {
        public static string firstname;
        public static string lastname;
        public static string groopnum;

        public Form5()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            //name = textBox1.Text;

            //... тут должно быть сохранение имени фамилии и группы и запуск теста
            Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
