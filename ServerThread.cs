using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace TrainServer
{
    internal class ServerThread
    {
        int port;

        public ServerThread(int port)
        {
            this.port = port;
            Thread servant = new Thread(new ThreadStart(Run));
            servant.Start();
        }

        public void Run()
        {
            Console.WriteLine("New Thread in port " + this.port);

            //---listen at the specified IP and port no.---
            TcpListener listener = new TcpListener(IPAddress.Parse(TrainServer.SERVER_IP), this.port);
            Console.WriteLine("Listening...");
            listener.Start();

            //---incoming client connected---
            TcpClient client = listener.AcceptTcpClient();

            //---get the incoming data through a network stream---
            NetworkStream nwStream = client.GetStream();
            byte[] buffer = new byte[client.ReceiveBufferSize];

            //---read incoming stream---
            int bytesRead = nwStream.Read(buffer, 0, client.ReceiveBufferSize);

            //---convert the data received into a string---
            string dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
            Console.WriteLine("Received : " + dataReceived);

            //---write back the text to the client---
            Console.WriteLine("Sending back : " + dataReceived);
            nwStream.Write(buffer, 0, bytesRead);
            client.Close();
            listener.Stop();
            Console.ReadLine();
        }

    }
}
