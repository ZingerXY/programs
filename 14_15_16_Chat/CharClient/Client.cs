using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServerData;

namespace CharClient
{
    public partial class Client : Form
    {
        public static Socket master;
        public static string name;
        public static string id;
        static string msg = "";
        string last_msg = "";

        public Client()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {        
        }


        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox2.Text;
            string ip = textBox3.Text;

            master = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse(ip), 4242);

            try
            {
                master.Connect(ipe);
            }
            catch
            {
                textBox1.AppendText("Cannot connect to host!\n");
                return;
            }

            textBox1.AppendText("Сonnected to the server!\n");
            timer1.Start();
            Thread t = new Thread(Data_IN);
            t.Start();
        }

        static void Data_IN()
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
                msg = "The server has disconnected!\n";
                Environment.Exit(0);
            }
        }

        static void DataManager(Packet p)
        {
            switch (p.packetType)
            {
                case PacketType.Registration:
                    id = p.Gdata[0];
                    break;

                case PacketType.Chat:
                    msg = p.Gdata[0] + ": " + p.Gdata[1] + "\n";
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string input = textBox4.Text;

            Packet p = new Packet(PacketType.Chat, id);
            p.Gdata.Add(name);
            p.Gdata.Add(input);
            master.Send(p.ToBytes());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(last_msg != msg)
            {
                textBox1.AppendText(msg);
                last_msg = msg;
            }
        }
    }

}
