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
    public partial class CustomerCartPopup : Form
    {
        public CustomerCartPopup()
        {
            InitializeComponent();
        }

        private void CustomerCartPopup_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersDBAppDataAdminCartView.tblcusCart' table. You can move, or remove it, as needed.
            this.tblcusCartTableAdapter.Fill(this.usersDBAppDataAdminCartView.tblcusCart);
            // TODO: This line of code loads data into the 'usersDBAppDataCus.tblReg' table. You can move, or remove it, as needed.
            this.tblRegTableAdapter.Fill(this.usersDBAppDataCus.tblReg);

        }

        private void btnAddtocart_Click(object sender, EventArgs e)
        {
            try
            {
                RegConnect food = new RegConnect();  // connect the database throught the class file
                food.conn.ConnectionString = food.locate; // connect the db throught locate file
                food.conn.Open();
                string add = "insert into tblcartView values ('"+txtproductid.Text+"','" + txtUsercart.Text + "','"+ comProductname.Text + "','"+txtproductprice.Text+"','"+txtproductquty.Text+"')";
                food.cmd.Connection = food.conn;
                food.cmd.CommandText = add;
                food.cmd.ExecuteNonQuery();

                food.conn.Close();


                MessageBox.Show("Completed!!", "Done", MessageBoxButtons.OK);
                CustomercusCart backa = new CustomercusCart();
                backa.Show();
                this.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }


        private void button26_Click_1(object sender, EventArgs e)
        {
            CustomercusCart ba = new CustomercusCart();
            ba.Show();
            this.Close();
        }

        private void txtproductquty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            // only allow decimal point

            if(e.KeyChar == '.' &&(sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled=true;
            }
        }
    }
}
