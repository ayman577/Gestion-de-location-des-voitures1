using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_location_des_voitures1
{
    public partial class letsStart : Form
    {
        public letsStart()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int startpoint;
        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void letsStart_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            prog.Value = startpoint;
            perc.Text = "" + startpoint;
            if (prog.Value == 100)
            {
                prog.Value = 0;
                timer1.Stop();
                LoginPage log = new LoginPage();
                log.Show();
                this.Hide();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
