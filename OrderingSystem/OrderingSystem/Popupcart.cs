using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OrderingSystem
{
    public partial class Popupcart : Form
    {
        public Popupcart()
        {
            InitializeComponent();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            cusCart popup = new cusCart();
            popup.Show();
            this.Hide();
        }

        private void Popupcart_Load(object sender, EventArgs e)
        {
            
        }
       

    }
}
