using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            this.Visible = false;
            //Avaa rekisteröitysmispaneeli
            RegisterPanel registerPanel = new RegisterPanel();
            registerPanel.ShowDialog();
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
