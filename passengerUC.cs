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
    public partial class passengerUC : UserControl
    {
        //katsotaan junan varaustilanteesta
        public static int freeSeats = 10;
        public passengerUC()
        {
            InitializeComponent();
        }

        private void passengerUC_Load(object sender, EventArgs e)
        {
            for(int i = 1; i<=freeSeats; i++)
            {
                passengerNoCB.Items.Add(i);
            }
        }
    }
}
