using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_ChatServer
{
    public partial class Form1 : Form
    {
        Socket server;
        Thread thread;

        public Form1()
        {
            InitializeComponent();
        }

        void service(object obj)
        {
            Socket link = (Socket)obj;
            link.Send(Encoding.UTF8.GetBytes("Привет от сервера!"));
        }

        void listener()
        {
            int port = int.Parse(textBox1.Text);
            IPEndPoint endpt = new IPEndPoint(IPAddress.Any, port);
            server = new Socket(SocketType.Stream, ProtocolType.Tcp);
            server.Bind(endpt);
            server.Listen(5);
            while (true)
            {
                Socket link;
                try
                {
                    link = server.Accept();
                }
                catch (Exception ex)
                {
                    break;
                }
                ParameterizedThreadStart start = new ParameterizedThreadStart(service);
                Thread thread = new Thread(start);
                thread.Start(link);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int port;
            if (int.TryParse(textBox1.Text, out port) == false)
            {
                MessageBox.Show("Порт должен быть числом.");
                return;
            }
            if (port < 1 || port > 65535)
            {
                MessageBox.Show("Неверный порт.");
                return;
            }

            ThreadStart start = new ThreadStart(listener);
            thread = new Thread(start);
            thread.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            server.Close();
            thread.Join();
        }
    }
}
