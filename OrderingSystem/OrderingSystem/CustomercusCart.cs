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
    public partial class CustomercusCart : Form
    {
     
        public CustomercusCart()
        {
            InitializeComponent();
        }

        private void cusCart_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersDBtblorCusDataApp.tblorcus' table. You can move, or remove it, as needed.
            this.tblorcusTableAdapter.Fill(this.usersDBtblorCusDataApp.tblorcus);
            // TODO: This line of code loads data into the 'usersDBAppDataAdminCartView.tblcusCart' table. You can move, or remove it, as needed.
            this.tblcusCartTableAdapter.Fill(this.usersDBAppDataAdminCartView.tblcusCart);
            // TODO: This line of code loads data into the 'usersDBAppDataCusCartView.tblcartview' table. You can move, or remove it, as needed.

        }
        //press the button and goto the loging page
        private void button25_Click(object sender, EventArgs e)
        {
            Costomerlogin cascart = new Costomerlogin();
            cascart.Show();
            this.Hide();
        }
                
        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }


        //press the button and goto another page
        private void button25_Click_1(object sender, EventArgs e)
        {
            Cuscartpro push = new Cuscartpro();
            push.Show();
            this.Hide();
        }

        //minimize the window
        private void button28_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }


        //pic box display
        private void pictureBox5_Click(object sender, EventArgs e)
        {
           
        }


        private void pictureBox9_Click(object sender, EventArgs e)
        {
            

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
        }



        // connect to the database and insert value in the db
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                RegConnect food = new RegConnect();  // connect the database throught the class file
                food.conn.ConnectionString = food.locate; // connect the db throught locate file
                food.conn.Open();
                string add = "insert into tblorcus values ('" + txtUsercart.Text + "','" + comProductname.Text + "','" + txtproductprice.Text + "','" + txtproductquty.Text + "','"+ txttot.Text+"')";
                food.cmd.Connection = food.conn;
                food.cmd.CommandText = add;
                food.cmd.ExecuteNonQuery();

                food.conn.Close();

                MessageBox.Show("Completed!!", "Done", MessageBoxButtons.OK);
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }



        private void comProductname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //application close
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // string convert to decimal value 
        private void txtproductquty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e. KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if(e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled=true;
            }
        }


        // calculate the total of food pice
        private void txtproductquty_TextChanged(object sender, EventArgs e)
        {
            double prdprice, prdqty, tot;
            double.TryParse(txtproductprice.Text, out prdprice);
            double.TryParse(txtproductquty.Text, out prdqty);
            
            tot = prdprice * prdqty;
            txttot.Text = tot.ToString();
        }
    }
    }

