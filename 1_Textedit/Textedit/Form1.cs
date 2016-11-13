using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Textedit
{
   
    public partial class Form1 : Form
    {
        bool nsave = false;
      

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            richTextBox1.Width = Width;
            richTextBox1.Height = Height - richTextBox1.Top - statusStrip1.Size.Height;
        }

        private void New_Doc(object sender, EventArgs e)
        {
            if (nsave)
                if (MessageBox.Show("Новый документ?", "Винмание!", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
            nsave = false;
            richTextBox1.Clear();
        }

        private void Open_Doc(object sender, EventArgs e)
        {
            if (nsave)
                if (MessageBox.Show("Новый документ?", "Винмание!", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.LoadFile(openFileDialog1.FileName);
            nsave = false;
            saveFileDialog1.Tag = 0;
        }

        private void Save_Doc(object sender, EventArgs e)
        {
            
            if ( saveFileDialog1.Tag.ToString() == "0")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName, (saveFileDialog1.FilterIndex == 1 ? RichTextBoxStreamType.RichText : RichTextBoxStreamType.PlainText));
                    nsave = true;
                    saveFileDialog1.Tag = 1;
                }
            }
            else
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, (saveFileDialog1.FilterIndex == 1 ? RichTextBoxStreamType.RichText : RichTextBoxStreamType.PlainText));
                nsave = true;
              }
        }

        private void Save_As_Doc(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                nsave = true;
                saveFileDialog1.Tag = 1;
                richTextBox1.SaveFile(saveFileDialog1.FileName, (saveFileDialog1.FilterIndex == 1 ? RichTextBoxStreamType.RichText : RichTextBoxStreamType.PlainText));
            }
        }


        private void Find_Doc(object sender, EventArgs e)
        {
            richTextBox1.Find(Interaction.InputBox("Введите строку для поиска.", "Поиск"));
        }

        private void Replace_Doc(object sender, EventArgs e)
        {

        }

        private void Font_Change(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void Font_Color(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void Word_Wrap(object sender, EventArgs e)
        {
            richTextBox1.WordWrap = !WordWrap.Checked;
            WordWrap.Checked = !WordWrap.Checked;
        }

        private void Text_Changed(object sender, EventArgs e)
        {
            nsave = true;
        }

        private void Exit_Doc(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (nsave)
            {
                if (MessageBox.Show("Сохранить файл перед выходом?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    Save_Doc(sender, e);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "lines: " + richTextBox1.Lines.Count().ToString() + " pos: " + richTextBox1.SelectionStart.ToString();
        }
    }
}
