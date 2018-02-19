using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainClient
{
    static class Program
    {
        public static RegisterPanel openedRegisterPanel;
        public static basePanel openedBasePanel;

        const int PORT_NO = 8080;
        public static string SERVER_IP = "127.0.0.1";
        public static int tcpPort;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            var client = new UdpClient();
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 11000); // endpoint where server is listening
            client.Connect(ep);

            // send data
            client.Send(new byte[] { 1, 2, 3, 4, 5 }, 5);

            // then receive tcp-port
            tcpPort = BitConverter.ToInt32(client.Receive(ref ep), 0);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            openedBasePanel = new basePanel();
            Application.Run(openedBasePanel);

        }
    }
}


