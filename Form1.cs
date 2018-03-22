using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainClient2
{
    public partial class Form1 : Form
    {

        protected static Boolean startUCVisible;
        protected static Boolean bookingUCVisible;
        //Asetukset ja matkan varaus napit toimivat vain kun tämä on true
        public static Boolean loginOk = false;

        public Form1()
        {
            InitializeComponent();
        }
        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        
        

        private void updatePanel_Paint(object sender, PaintEventArgs e)
        {
            startUC1.BringToFront();
        }

        private void settingsBTN_Click(object sender, EventArgs e)
        {

        }

        private void bookTripBTN_Click(object sender, EventArgs e)
        {
            if (loginOk)
            {
                bookingUC1.BringToFront();
            }
        }
    }
}
