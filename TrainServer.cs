using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TrainServer
{
    class TrainServer
    {
        const int SERVER_PORT_NO = 8080;
        //const int CLIENT_PORT_NO = 3000;
        const string SERVER_IP = "127.0.0.1";

        public static void Main(String[] args)
        {

            
            int CLIENT_COUNT = 1;
            
            UdpClient udpServer = new UdpClient(11000);

            while (true)
            {
                var remoteEP = new IPEndPoint(IPAddress.Any, 11000);
                var data = udpServer.Receive(ref remoteEP); // listen on port 11000
                Console.Write("Connection from client, sending back port no: " + (11000+CLIENT_COUNT));

                //Lähetetään tcp-portti
                byte[] tcpPort = BitConverter.GetBytes(11000 + CLIENT_COUNT);
                udpServer.Send(tcpPort, tcpPort.Length, remoteEP); // reply back

            }

        }
        }
    }


