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
    public partial class startUC : UserControl
    {

        public startUC()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            //Tähän tarkastus että kirjautumistiedot ok
            //jos ok
            Form1.loginOk = true;
        }
    }
}
