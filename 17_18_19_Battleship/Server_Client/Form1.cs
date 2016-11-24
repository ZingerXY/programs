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

        static int[,] f_data = new int[f_width, f_height];
        static int[,] f_data_enemy = new int[f_width, f_height];

        int[] ship = new int[4] {4,3,2,1};
        bool ready = false;

        static string msg = "";
        string last_msg = "";
        static string mode = "";

        SolidBrush brush = new SolidBrush(Color.Black);

        static Socket master;
        static Socket listenerSocket;
        static ClientData clients;
        Thread listenThread;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = Packet.GetIP4Address();
        }
        // Отрисовка своего поля
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
                        case 0: brush.Color = Color.FromArgb(100, 100, 255); break; // вода
                        case 1: brush.Color = Color.FromArgb(255, 200, 0); break; // корабль
                        case 2: brush.Color = Color.FromArgb(129, 80, 206); break; // рядом с кораблем
                        case 3: brush.Color = Color.FromArgb(0, 0, 0); break; // убил
                        case 4: brush.Color = Color.FromArgb(160, 160, 255); break; // промазал
                    }
                    e.Graphics.FillRectangle(brush, x * c_width, y * c_height, c_width - 1, c_height - 1);
                }
        }
        // Отрисовка вражеского поля
        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);

            c_width = pictureBox2.Width / f_width;
            c_height = pictureBox2.Height / f_height;

            for (int y = 0; y < f_height; y++)
                for (int x = 0; x < f_width; x++)
                {
                    switch (f_data_enemy[x, y])
                    {
                        case 0: brush.Color = Color.FromArgb(100, 100, 255); break; // вода
                        case 1: brush.Color = Color.FromArgb(255, 200, 0); break; // корабль
                        case 2: brush.Color = Color.FromArgb(129, 80, 206); break; // рядом с кораблем
                        case 3: brush.Color = Color.FromArgb(0, 0, 0); break; // убил
                        case 4: brush.Color = Color.FromArgb(160, 160, 255); break; // промазал
                    }
                    e.Graphics.FillRectangle(brush, x * c_width, y * c_height, c_width - 1, c_height - 1);
                }
        }

        bool checkCell(int n, int[,] arr, int x, int y, bool chk)
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
            else if(chk)
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
            instalShip(c_x, c_y, radioButton1.Checked);
            if(ship.Sum() == 0) Ready();
            pictureBox1.Invalidate();
        }

        bool instalShip(int c_x,int c_y,bool check)
        {
            int count = listBox1.SelectedIndex + 1;
            if (ship[listBox1.SelectedIndex] < 1) return false;
            int[,] f_temp_data = new int[f_width, f_height];
            Array.Copy(f_data, f_temp_data, f_data.Length);

            if (check)
                for (int i = 0; i < count; i++)
                {
                    if (c_x + i >= f_temp_data.GetLength(0)) return false;
                    if (!checkCell(i, f_temp_data, c_x + i, c_y, check)) return false;
                    f_temp_data[c_x + i, c_y] = 1;
                }
            else
                for (int i = 0; i < count; i++)
                {
                    if (c_y + i >= f_temp_data.GetLength(1)) return false;
                    if (!checkCell(i, f_temp_data, c_x, c_y + i, check)) return false;
                    f_temp_data[c_x, c_y + i] = 1;
                }

            Array.Copy(f_temp_data, f_data, f_temp_data.Length);
            ship[listBox1.SelectedIndex]--;
            listBox1.Items.Clear();
            for (int i = 0; i < 4; i++)
                listBox1.Items.Add((i + 1) + " - " + ship[i]);
            listBox1.SelectedIndex = count - 1;
            return true;
        }
        // Вкл и выкл готовности к игре
        void Ready()
        {
            ready = !ready;
            tabControl1.Enabled = ready;         
        }
        // Рандомная расстановка кораблей
        private void RandShips_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int x, y;
            bool chk;
            for (int i = 3; i >= 0; i--)
            {
                listBox1.SelectedIndex = i;
                do
                {
                    x = r.Next(0, 10);
                    y = r.Next(0, 10);
                    chk = r.Next(0, 2) > 0 ? true : false;
                    instalShip(x, y, chk);
                } while (ship[i] > 0);
            }
            pictureBox1.Invalidate();
            Ready();
        }
        // Очистка кораблей с поля
        private void Clear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < 4; i++)
            {
                ship[i] = 4 - i;
                listBox1.Items.Add((i + 1) + " - " + ship[i]);
            }
            Array.Clear(f_data, 0, f_data.Length);
            pictureBox1.Invalidate();
            if(ready)
                Ready();
        }

        bool checkLoss()
        {
            for (int y = 0; y < f_height; y++)
                for (int x = 0; x < f_width; x++)
                    if (f_data[x, y] == 1)
                        return false;
            return true;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (mode == "") return;
            int x = e.X / c_width;
            int y = e.Y / c_height;
            Send(1, x, y);
        }
        // Сервер
        // Запуск сервера
        private void StartServer_Click(object sender, EventArgs e)
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

            listBox2.SelectedIndex = listBox2.Items.Add("Starting server on " + Packet.GetIP4Address());
            listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPEndPoint ip = new IPEndPoint(IPAddress.Parse(Packet.GetIP4Address()), port);
            listenerSocket.Bind(ip);

            timer1.Start();
            mode = "Server";
            Text += ": "+mode;
            listenThread = new Thread(ListenThread);
            listenThread.Start();
        }

        static void ListenThread()
        {
            while (true)
            {
                listenerSocket.Listen(0);
                clients = new ClientData(listenerSocket.Accept());
                return;
            }
        }

        static void Data_IN_server(object cSocket)
        {
            Socket clientSocket = (Socket)cSocket;

            byte[] Buffer;
            int readBytes;

            try
            {
                while (true)
                {
                    Buffer = new byte[clientSocket.SendBufferSize];
                    readBytes = clientSocket.Receive(Buffer);

                    if (readBytes > 0)
                    {
                        Packet packet = new Packet(Buffer);
                        DataManager(packet);
                    }
                }
            }
            catch (SocketException ex)
            {
                msg = "A client disconnected!";
            }
        }

        class ClientData
        {
            public Socket clientSocket;
            public Thread clientThread;

            public ClientData()
            {
                clientThread = new Thread(Data_IN_server);
                clientThread.Start(clientSocket);
                SendRegistrationPacket();
            }

            public ClientData(Socket clientSocket)
            {
                this.clientSocket = clientSocket;
                clientThread = new Thread(Data_IN_server);
                clientThread.Start(clientSocket);
                SendRegistrationPacket();
            }

            public void SendRegistrationPacket()
            {
                Packet p = new Packet();
                try
                {
                    clientSocket.Send(p.ToBytes());
                }
                catch
                {

                }
                
            }
        }

        // Клиент
        private void StartClient_Click(object sender, EventArgs e)
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

            master = new Socket(SocketType.Stream, ProtocolType.Tcp);

            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse(textBox1.Text), port);

            try
            {
                master.Connect(textBox1.Text, port);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                listBox2.SelectedIndex = listBox2.Items.Add("Cannot connect to host!");
                return;
            }

            listBox2.SelectedIndex = listBox2.Items.Add("Сonnected to the server!");
            timer1.Start();
            mode = "Client";
            Text += ": " + mode;
            Thread t = new Thread(Data_IN_client);
            t.Start();
        }

        void Data_IN_client()
        {
            byte[] Buffer;
            int readBytes;

            try
            {
                while (true)
                {
                    Buffer = new byte[master.SendBufferSize];
                    readBytes = master.Receive(Buffer);

                    if (readBytes > 0)
                    {
                        DataManager(new Packet(Buffer));
                    }
                }
            }
            catch (SocketException ex)
            {
                msg = "The server has disconnected!";
                Environment.Exit(0);
            }
        }

        static void DataManager(Packet p)
		{
            switch (p.tp)
            {
                case 0:
                    msg = "Сonnected client";
                    break;
                case 1: 
                    if(f_data[p.X,p.Y] == 1 || f_data[p.X, p.Y] == 3)
                    {
                        f_data[p.X, p.Y] = 3; // убит 
                        msg = "Враг поразил цель" + (p.X + 1) + ":" + (p.Y + 1);
                        Send(3, p.X, p.Y);                       
                    }                       
                    else
                    {
                        f_data[p.X, p.Y] = 4; // промазал 
                        msg = "Враг промахнулся" + (p.X + 1) + ":" + (p.Y + 1);
                        Send(4, p.X, p.Y);
                    }                    
                    break;
                case 2:
                    msg = "Win";
                    break;
                case 3:
                    f_data_enemy[p.X, p.Y] = 3; // убит 
                    msg = "Вы попали в корабль" + (p.X + 1) + ":" + (p.Y + 1);
                    break;
                case 4:
                    f_data_enemy[p.X, p.Y] = 4; // промазал 
                    msg = "Мимо" + (p.X + 1) + ":" + (p.Y + 1);
                    break;
            }
		}

        private void TimeClient_Tick(object sender, EventArgs e)
        {
            if (last_msg != msg)
            {
                listBox2.SelectedIndex = listBox2.Items.Add(msg);
                last_msg = msg;
                pictureBox1.Invalidate();
                pictureBox2.Invalidate();
                if(msg == "Win")
                {
                    MessageBox.Show("Победа! Ваш противник повержен!");
                    timer1.Stop();
                }
                if (checkLoss())
                {
                    Send(2, 0, 0);
                    MessageBox.Show("Поражение! Ваш противник одеражл победу!");                  
                    timer1.Stop();
                }

            }
        }

        static void Send(int tp, int x, int y)
        {
            Packet packet = new Packet(tp, x, y);
            if (mode == "Client")
                master.Send(packet.ToBytes());
            else if (mode == "Server")
                clients.clientSocket.Send(packet.ToBytes());
        }
    }

    public class Packet
    {
        public int tp, X, Y;

        public Packet()
        {
            tp = 0; X = 0; Y = 0;
        }

        public Packet(byte[] data)
        {
            int[]arr = new int[data.Length / sizeof(int)];
            Buffer.BlockCopy(data, 0, arr, 0, arr.Length);
            this.tp = arr[0];
            this.X = arr[1];
            this.Y = arr[2];
        }

        public Packet(int tp,int X, int Y)
        {
            this.tp = tp;
            this.X = X;
            this.Y = Y;
        }

        public byte[] ToBytes()
        {
            int[] arr = new int[3];
            arr[0] = tp;
            arr[1] = X;
            arr[2] = Y;

            byte[] result = new byte[arr.Length * sizeof(int)];
            Buffer.BlockCopy(arr, 0, result, 0, result.Length);
            return result;
        }

        public static string GetIP4Address()
        {
            IPAddress[] ips = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress i in ips)
            {
                if (i.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    return i.ToString();
            }
            return "127.0.0.1";
        }
    }

}
