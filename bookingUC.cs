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
        public bookingUC()
        {
            InitializeComponent();
            /*SidePanel.Height = routeBTN.Height;
            SidePanel.Top = routeBTN.Top;*/
        }

        private void routeBTN_Click(object sender, EventArgs e)
        {
            /*
            SidePanel.Height = routeBTN.Height;
            SidePanel.Top = routeBTN.Top;*/
        }


        //Kun painetaan matkustajat-välilehdelle, niin siirretään
        //sidepanel oikealle kohdalle ja avataan passengerUC näkyviin
        private void passengerBTN_Click(object sender, EventArgs e)
        {
            /*SidePanel.Height = passengerBTN.Height;
            SidePanel.Top = passengerBTN.Top;*/
            
        }


        private void scheduleBTN_Click(object sender, EventArgs e)
        {
            /*Sivupaneelin siirto oikealle kohdalle
            SidePanel.Height = scheduleBTN.Height;
            SidePanel.Top = scheduleBTN.Top;*/
        }

        private void confirmBTN_Click(object sender, EventArgs e)
        {
            /*Sivupaneelin siirto oikealle kohdalle
            SidePanel.Height = confirmBTN.Height;
            SidePanel.Top = confirmBTN.Top;*/
        }

    }
}
