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

namespace Server_Client
{
    public partial class Form1 : Form
    {
        const int f_width = 10;
        const int f_height = 10;

        int c_width;
        int c_height;

        int[,] f_data = new int[f_width, f_height];

        int[] ship = new int[4] {4,3,2,1};

        SolidBrush brush = new SolidBrush(Color.Black);

        Socket server;
        Thread thread;
        Socket client;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);

            c_width = pictureBox1.Width / f_width;
            c_height = pictureBox1.Height / f_height;

            for(int y = 0; y < f_height; y++)
                for(int x = 0; x < f_width; x++)
                {
                    switch (f_data[x, y])
                    {
                        case 0: brush.Color = Color.FromArgb(100, 100, 255); break;
                        case 1: brush.Color = Color.FromArgb(255, 200, 0); break;
                        case 2: brush.Color = Color.FromArgb(129, 80, 206); break;
                    }
                    e.Graphics.FillRectangle(brush, x * c_width, y * c_height, c_width - 1, c_height - 1);
                }
        }

        bool checkCell(int n, int[,] arr, int x, int y)
        {
            if(n == 0)
            {
                for(int i = x-1; i < x+2; i++)
                    for (int j = y-1; j < y+2; j++)
                    {
                        if (i < 0 || i >= arr.GetLength(0) || j < 0 || j >= arr.GetLength(1)) continue;
                        if (arr[i, j] == 0) arr[i, j] = 2;
                        if (arr[i, j] == 1) return false;
                    }
            }
            else if(radioButton1.Checked)
            {
                for (int i = x; i < x + 2; i++)
                    for (int j = y - 1; j < y + 2; j++)
                    {
                        if (i < 0 || i >= arr.GetLength(0) || j < 0 || j >= arr.GetLength(1)) continue;
                        if(arr[i, j] == 0) arr[i, j] = 2;
                        if (arr[i, j] == 1) return false;
                    }
            }
            else
            {
                for (int i = x - 1; i < x + 2; i++)
                    for (int j = y; j < y + 2; j++)
                    {
                        if (i < 0 || i >= arr.GetLength(0) || j < 0 || j >= arr.GetLength(1)) continue;
                        if (arr[i, j] == 0) arr[i, j] = 2;
                        if (arr[i, j] == 1) return false;
                    }
            }
            return true;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedIndex < 0) return;
            int c_x = e.X / c_width;
            int c_y = e.Y / c_height;
            int count = listBox1.SelectedIndex + 1;
            if (ship[listBox1.SelectedIndex] < 1) return;
            int[,] f_temp_data = new int[f_width, f_height];
            Array.Copy(f_data, f_temp_data, f_data.Length);

            if (radioButton1.Checked)
                for(int i = 0; i < count; i++)
                {
                    if (c_x + i >= f_temp_data.GetLength(0)) return;
                    if (!checkCell(i, f_temp_data, c_x + i, c_y)) return;
                    f_temp_data[c_x + i, c_y] = 1;
                }
            else
                for (int i = 0; i < count; i++)
                {
                    if (c_y + i >= f_temp_data.GetLength(1)) return;
                    if (!checkCell(i, f_temp_data, c_x, c_y + i)) return;
                    f_temp_data[c_x, c_y + i] = 1;
                }

            Array.Copy(f_temp_data, f_data, f_temp_data.Length);
            ship[listBox1.SelectedIndex]--;
            listBox1.Items.Clear();
            for (int i = 0; i < 4; i++)
                listBox1.Items.Add((i + 1) + " - " + ship[i]);
            listBox1.SelectedIndex = count - 1;
            pictureBox1.Invalidate();
        }
        // Сервер
        private void Start_Click(object sender, EventArgs e)
        {
            int port;
            if (int.TryParse(textBox3.Text, out port) == false)
            {
                MessageBox.Show("Порт должен быть числом.");
                return;
            }
            if (port < 1 || port > 65535)
            {
                MessageBox.Show("Неверный порт.");
                return;
            }
            thread = new Thread(listener);
            thread.Start();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            server.Close();
            thread.Join();
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
                Thread thread = new Thread(service);
                thread.Start(link);
            }
        }
        // Сервер
    }
}
