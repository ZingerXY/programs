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

namespace MyTestProfi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            StreamReader Y = new StreamReader(Program.F1.X);
            for (int i = 0; i != Program.F1.conf.Length; i++)
            {
                Program.F1.conf[i] = int.Parse(Y.ReadLine());
            }
            textBox1.Text = Program.F1.conf[0].ToString();
            textBox2.Text = Program.F1.conf[1].ToString();
            textBox3.Text = Program.F1.conf[2].ToString();
            textBox4.Text = Program.F1.conf[3].ToString();

            Y.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            StreamWriter Y = new StreamWriter(Program.F1.X);
            Y.WriteLine(textBox1.Text);
            Y.WriteLine(textBox2.Text);
            Y.WriteLine(textBox3.Text);
            Y.WriteLine(textBox4.Text);
            Y.WriteLine(Program.F1.conf[4].ToString());
            Y.Close();
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
