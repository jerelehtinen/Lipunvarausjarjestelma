using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainClient2.UserControls
{
    public partial class bookingUC : UserControl
    {
        //käyttäjän valitsemat matkan tiedot
        public static String departureCity;
        public static String arrivalCity;
        public static String passengerNo;
        public static String departureTime;
        public static String arrivalTime;
        public static String price;

        public bookingUC()
        {
            InitializeComponent();
            routeUC1.BringToFront();
            
        }

        private void routeBTN_Click(object sender, EventArgs e)
        {
            
            SidePanel.Height = routeBTN.Height;
            SidePanel.Top = routeBTN.Top;
            routeUC1.BringToFront();
            refreshLabels();
        }




        private void scheduleBTN_Click(object sender, EventArgs e)
        {
            //Sivupaneelin siirto oikealle kohdalle
            SidePanel.Height = scheduleBTN.Height;
            SidePanel.Top = scheduleBTN.Top;
            scheduleUC1.BringToFront();
            refreshLabels();
        }

        private void pickBTN_Click(object sender, EventArgs e)
        {
            //Sivupaneelin siirto oikealle kohdalle
            SidePanel.Height = pickBTN.Height;
            SidePanel.Top = pickBTN.Top;
            pickUC1.BringToFront();
            refreshLabels();
        }

        private void confirmBTN_Click(object sender, EventArgs e)
        {
            //Sivupaneelin siirto oikealle kohdalle
            SidePanel.Height = confirmBTN.Height;
            SidePanel.Top = confirmBTN.Top;
            confirmUC1.BringToFront();
            refreshLabels();
        }

        public void refreshLabels()
        {
            this.departureLBL.Text = "Lähtöasema: " + departureCity;
            this.arriveLBL.Text = "Pääteasema: " + arrivalCity;
            this.passengerNoLBL.Text = "Matkustajien lukumäärä: " + passengerNo;
            this.departureTimeLBL.Text = "Lähtöaika: " + departureTime;
            this.arrivalTimeLBL.Text = "Saapumisaika: " + arrivalTime;
            this.priceLBL.Text = "Matkan hinta: " + price;
        }

        private void refreshBTN_Click(object sender, EventArgs e)
        {
            refreshLabels();
        }
    }
}
