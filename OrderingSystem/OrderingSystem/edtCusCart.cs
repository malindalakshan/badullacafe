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
    public partial class edtCusCart : Form
    {
        public edtCusCart()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminDash cartback = new AdminDash();
            cartback.Show();
            this.Hide();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void edtCusCart_Load(object sender, EventArgs e)
        {
          
            


        }
    }
}
