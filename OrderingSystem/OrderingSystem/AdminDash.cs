using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderingSystem
{
    public partial class AdminDash : Form
    {
        public AdminDash()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void adlogout_Click(object sender, EventArgs e)
        {
            Selectrole adlogout = new Selectrole();
            adlogout.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminedtCusAcc cusAcc = new AdminedtCusAcc();
            cusAcc.Show();
            this.Hide();
        }

        private void editcartad_Click(object sender, EventArgs e)
        {
            AdminedtcusCartAd cusCartedt = new AdminedtcusCartAd();
            cusCartedt.Show();
            this.Hide();
        }

        private void cusre_Click(object sender, EventArgs e)
        {
            AdminviewCusFeed cusFeed = new AdminviewCusFeed();
            cusFeed.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminViewCusCart cusCart = new AdminViewCusCart();
            cusCart.Show();
            this.Hide();
        }
    }
}
