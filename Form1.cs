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
        public Form1()
        {
            InitializeComponent();
        }
        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            panel4.Controls.Remove(bookingUC1);
            panel4.Controls.Add(startUC1);*/
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            panel4.Controls.Add(bookingUC1);
            panel4.Controls.Remove(startUC1);*/
        }

    }
}
