using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderingSystem
{
    public partial class CustomerPay : Form
    {
        public string fdprice { get; set; }
        String randomCode;
        public static string to;

        public CustomerPay()
        {
            InitializeComponent();
        }
        
         

        //exit the application
        private void button26_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // back to my cart
        private void btnmax_Click(object sender, EventArgs e)
        {
            Cuscartpro backcart = new Cuscartpro();
            backcart.Show();
            this.Hide();    
        }


        //hide the window
        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmFeedback_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomerPay_Load(object sender, EventArgs e)
        {
            gettxttot.Text = fdprice;
         

            // TODO: This line of code loads data into the 'usersDBFeedAppData.tblfeed' table. You can move, or remove it, as needed.
            this.tblfeedTableAdapter.Fill(this.usersDBFeedAppData.tblfeed);
            // TODO: This line of code loads data into the 'usersDBtblorCusDataApp.tblorcus' table. You can move, or remove it, as needed.
            this.tblorcusTableAdapter.Fill(this.usersDBtblorCusDataApp.tblorcus);

            frmFeedback.Visible = false;
            grBanner.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string from, pass, messageBody;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (txtEmail.Text).ToString();
            from = "badullacafe123@gmail.com";
            pass = "utxyuwjvfuhnmnnz";
            messageBody =
                "Dear Valued Customer," +Environment.NewLine + Environment.NewLine +

                "Your Email Address " + txtEmail.Text + Environment.NewLine +
                "Your phone number  " + txtmobile.Text + Environment.NewLine +
                "Your order price   " + gettxttot.Text + Environment.NewLine +
                "Your Home Address  " + txthome.Text + Environment.NewLine +Environment.NewLine +

                "Your order has been completed, and it was delivered within 30 minutes." + Environment.NewLine +
                "This order number "+ randomCode +" give to our delivery guy and get the order" + Environment.NewLine + Environment.NewLine +
                "*****Thank you  deal with us and have a nice day*****" + Environment.NewLine+ Environment.NewLine+
                "Warm Regards" + Environment.NewLine+
                "This is a system-generated email. Please do not reply" + Environment.NewLine ;


            message.To.Add(to);
            message.From =new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Notification";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new System.Net.NetworkCredential(from, pass);


            try
            {
                smtp.Send(message);
                MessageBox.Show("Code send succesfully");

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            if (MessageBox.Show("Check your email and get verify Code", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                frmFeedback.Visible = true;
                frmPyment.Visible = false;
                grBanner.Visible = false;

            }

        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                RegConnect feed = new RegConnect();  // connect the database throught the class file
                feed.conn.ConnectionString = feed.locate; // connect the db throught locate file
                feed.conn.Open();
                string add = "insert into tblfeed values ('"+txtfeeduser.Text+"','"+txtfeedback.Text+"')";
                feed.cmd.Connection = feed.conn;
                feed.cmd.CommandText = add;
                feed.cmd.ExecuteNonQuery();

                feed.conn.Close();

                MessageBox.Show("Feed Back Saved", "Done", MessageBoxButtons.OK);
                frmFeedback.Visible = false;
                grBanner.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Check your email and get verify Code", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Costomerlogin newreg = new Costomerlogin();
                newreg.Show();
                this.Hide();

            }
        }
    }
}

