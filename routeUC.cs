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
        public static String departureCity;

        public routeUC()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void routeUC_Load(object sender, EventArgs e)
        {
            foreach (String city in cities)
            {
                startCB.Items.Add(city);
            }

        }

        private void startBTN_Click(object sender, EventArgs e)
        {
            //Luetaan valittu lahtopaikka
            departureCity = startCB.SelectedItem.ToString();

            //bookingUC.departureCityLbl.Text = "Lähtöasema: " + departureCity;
        }
    }
}

