using System;
using System.Collections;
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
    public partial class Form4 : Form
    {        

        
        ArrayList list = new ArrayList();
        ArrayList hello = new ArrayList();

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            StreamReader Z = new StreamReader(Program.F1.X);
            for (int i = 0; i != Program.F1.conf.Length; i++)
            {
                Program.F1.conf[i] = int.Parse(Z.ReadLine());
            }
            for (int i = 0; i != Program.F1.conf[4]; i++)
            {
                question q = new question(Z);
                list.Add(q);
                listBox1.Items.Add(q.textQuestion);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            return;
            question n = (question) list[listBox1.SelectedIndex];
            question.Text = n.textQuestion;


            for (int i = 0; i < 5; i++)
                Controls["textBox" + i].Text = n.answers[i];

            foreach(Control c in this.Controls)
            {
                if (c is RadioButton)
                    if ((c as RadioButton).Name == "radioButton" + n.correct)
                        (c as RadioButton).Checked = true;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            if (question.Text == "")
            {
                MessageBox.Show("Для начала введите вопрос");
                return;
            }
            /*for (int i = 0; i < 5; i++)
            {
                if(Controls["textBox" + i].Text = n.answers[i];
            }*/
                

        }

        
    }

    public class question
    {
        public question(StreamReader A)
        {
            correct = int.Parse(A.ReadLine());
            textQuestion = A.ReadLine();
            for (int i = 0; i != answers.Length; i++)
                answers[i] = A.ReadLine();
        }
        public question()
        {
            correct = 0;
            textQuestion = "";
            for (int i = 0; i != answers.Length; i++)
                answers[i] = "";
        }
        public int correct;
        public string textQuestion;
        public string[] answers = new string[5];

    }
}
