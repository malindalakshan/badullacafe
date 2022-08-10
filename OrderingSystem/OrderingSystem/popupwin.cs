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
    public partial class popupwin : Form
    {
        public popupwin()
        {
            InitializeComponent();
        }

        private void BTN_a_Click(object sender, EventArgs e)
        {
            try
            {
                RegConnect o = new RegConnect();
                o.conn.ConnectionString = o.locate;
                o.conn.Open();
                string insertcart = "insert into tblcusCart values ('" + txtu.Text + "','" +comb.SelectedItem.ToString()+ "','" + txtp.Text + "','" + txtq.Text + "')";
                o.cmd.Connection = o.conn;
                o.cmd.CommandText = insertcart;
                o.cmd.ExecuteNonQuery();

                o.conn.Close();


                MessageBox.Show("Add to cart", "Done", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void popupwin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersDBCusCartApp.tblcusCart' table. You can move, or remove it, as needed.
            this.tblcusCartTableAdapter.Fill(this.usersDBCusCartApp.tblcusCart);

        }
    }
}
