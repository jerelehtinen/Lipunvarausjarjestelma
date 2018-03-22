using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace TrainClient2.UserControls
{
    public partial class routeUC : UserControl
    {
        public static ArrayList cities = new ArrayList() { "Helsinki", "Joensuu", "Jyväskylä", "Kemi", "Kittilä", "Kouvola", "Kuopio", "Kuusamo", "Lahti", "Lappeenranta", "Mikkeli", "Oulu", "Pori", "Porvoo", "Rovaniemi", "Tampere", "Turku", "Vaasa" };
        public static int freeSeats = 10;

        public routeUC()
        {
            InitializeComponent();
        }

        //Täytetään comboboxit
        private void routeUC_Load(object sender, EventArgs e)
        {
            foreach (String city in cities)
            {
                startCB.Items.Add(city);
                arriveCB.Items.Add(city);
            }

            for (int i = 1; i <= freeSeats; i++)
            {
                passengerNoCB.Items.Add(i);
            }

        }
        //
        //luetaan comboboxien arvot
        //
        private void startCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            bookingUC.departureCity = startCB.SelectedItem.ToString();
        }

        private void arriveCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            bookingUC.arrivalCity = arriveCB.SelectedItem.ToString();
        }

        private void passengerNoCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            bookingUC.passengerNo = passengerNoCB.SelectedItem.ToString();
        }
    }
}

