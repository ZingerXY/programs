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
    public partial class Form1 : Form
    {
        public string X = "";

        public int [] conf = new int [] {10, 90, 75, 60, 0};
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
         
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                X = saveFileDialog1.FileName;
                StreamWriter Y = new StreamWriter(X);
                for (int i = 0; i != conf.Length; i++)
                    Y.WriteLine(conf[i]);
                Y.Close();
                labelPath.Text = X;
                enableButton();
            }
        }

        private void enableButton ()
        {
            buttonConfig.Enabled = true;
            buttonEdit.Enabled = true;
            buttonStart.Enabled = true;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void buttonConfig_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                X = openFileDialog1.FileName;
                labelPath.Text = X;
                enableButton();
            }

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }
    }
}
