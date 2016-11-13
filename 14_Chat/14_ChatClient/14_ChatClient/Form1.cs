using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_ChatClient
{
    public partial class Form1 : Form
    {
        Socket client;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int port;
            if (int.TryParse(textBox2.Text, out port) == false)
            {
                MessageBox.Show("Порт должен быть числом.");
                return;
            }
            if (port < 1 || port > 65535)
            {
                MessageBox.Show("Неверный порт.");
                return;
            }

            label3.Text = "Подключение...";
            Application.DoEvents();

            client = new Socket(SocketType.Stream, ProtocolType.Tcp);

            try
            {
                client.Connect(textBox1.Text, port);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                label3.Text = "Ошибка подключения!";
                return;
            }

            label3.Text = "Подключено!";
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            client.Close();
            label3.Text = "Отключено.";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            byte[] data = new byte[100];
            int len;
            try
            {
                len = client.Receive(data);
            }
            catch (Exception ex)
            {
                button2_Click(null, new EventArgs());
                return;
            }
            if (len == 0)
            {
                button2_Click(null, new EventArgs());
                return;
            }
            string msg = Encoding.UTF8.GetString(data);
            listBox1.SelectedIndex = listBox1.Items.Add(msg);
        }
    }
}
