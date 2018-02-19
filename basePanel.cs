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

namespace TrainClient
{
    public partial class basePanel : Form
    {


        public basePanel()
        {
            InitializeComponent();

        }


        private void RegisterLbl_Click(object sender, EventArgs e)
        {
            //piilota kirjautumisnäkymä rekisteröinnin ajaksi
            Program.openedBasePanel.Visible = false;
            //Avaa rekisteröitysmispaneeli
            Program.openedRegisterPanel = new RegisterPanel();
            Program.openedRegisterPanel.ShowDialog();

        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
 
            //---data to send to the server---
            string textToSend = DateTime.Now.ToString();

            //---create a TCPClient object at the IP and port no.---
            TcpClient client = new TcpClient(Program.SERVER_IP, Program.tcpPort);
            NetworkStream nwStream = client.GetStream();
            byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(textToSend);

            //---send the text---
            Console.WriteLine("Sending : " + textToSend);
            nwStream.Write(bytesToSend, 0, bytesToSend.Length);

            //---read back the text---
            byte[] bytesToRead = new byte[client.ReceiveBufferSize];
            int bytesRead = nwStream.Read(bytesToRead, 0, client.ReceiveBufferSize);
            Console.WriteLine("Received : " + Encoding.ASCII.GetString(bytesToRead, 0, bytesRead));
            Console.ReadLine();
            client.Close();

            //TCP yhteys muodostettu, voidaan sulkea kirjautumisnäkymä
            Program.openedBasePanel.Close();
        }
    }
}
