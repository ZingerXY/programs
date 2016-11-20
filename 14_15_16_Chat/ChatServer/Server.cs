using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using ServerData;


namespace ChatServer
{
    public partial class Server : Form
    {

        static Socket listenerSocket;
        static List<ClientData> _clients;
        Thread listenThread;
        static string msg = "";
        string last_msg = "";

        public Server()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // Запуск сервера
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("Starting server on " + Packet.GetIP4Address());
            listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _clients = new List<ClientData>();

            IPEndPoint ip = new IPEndPoint(IPAddress.Parse(Packet.GetIP4Address()), 4242);
            listenerSocket.Bind(ip);

            timer1.Start();
            
            listenThread = new Thread(ListenThread);
            listenThread.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        static void ListenThread()
        {
            while (true) //continuously accept client requests
            {
                listenerSocket.Listen(0);
                _clients.Add(new ClientData(listenerSocket.Accept()));
            }
        }

        public static void Data_IN(object cSocket)
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

        public static void DataManager(Packet p)
        {
            switch (p.packetType)
            {
                case PacketType.Chat:
                    foreach (ClientData c in _clients)
                    {
                        c.clientSocket.Send(p.ToBytes());
                    }
                    break;
            }
        }

        class ClientData
        {
            public Socket clientSocket;
            public Thread clientThread;
            public string id;

            public ClientData()
            {
                id = Guid.NewGuid().ToString();
                clientThread = new Thread(Data_IN);
                clientThread.Start(clientSocket);
                SendRegistrationPacket();
            }

            public ClientData(Socket clientSocket)
            {
                this.clientSocket = clientSocket;
                id = Guid.NewGuid().ToString();
                clientThread = new Thread(Data_IN);
                clientThread.Start(clientSocket);
                SendRegistrationPacket();
            }

            public void SendRegistrationPacket()
            {
                Packet p = new Packet(PacketType.Registration, "server");
                p.Gdata.Add(id);
                clientSocket.Send(p.ToBytes());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (last_msg != msg)
            {
                textBox1.AppendText(msg);
                last_msg = msg;
            }
        }
    }

    
}
