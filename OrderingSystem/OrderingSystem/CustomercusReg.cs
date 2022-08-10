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
    public partial class CustomercusReg : Form
    {
        public CustomercusReg()
        {
            InitializeComponent();

        }
        
        private void cusCreate_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "" || txtpass.Text == "")
            {
                MessageBox.Show("Fill the Form");
            }

            else if (txtusername.Text != null && txtpass.Text != null)
            {

                try
                {
                    RegConnect obj = new RegConnect();
                    obj.conn.ConnectionString = obj.locate;
                    obj.conn.Open();
                    string insertuser = "insert into tblReg values ('"+txtfirst.Text+"','"+txtemail.Text+"','"+txtusername.Text+"','"+txtpass.Text+"','"+txtcpass.Text+"','"+txttele.Text+"','"+txthome.Text+"')";
                    obj.cmd.Connection = obj.conn;
                    obj.cmd.CommandText = insertuser;
                    obj.cmd.ExecuteNonQuery();

                    obj.conn.Close();
                   

                    MessageBox.Show("Register has been completed","Done",MessageBoxButtons.OK);

                    Costomerlogin logreg = new Costomerlogin();
                    logreg.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }
            else
            {
                MessageBox.Show("Please Fill The Registration Form");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtpass.PasswordChar = '\0';
                txtcpass.PasswordChar ='\0';
            }
            else
            {
                txtpass.PasswordChar = '.';
                txtcpass.PasswordChar = '.';
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cusReg_Load(object sender, EventArgs e)
        {
           
            this.tblRegTableAdapter.Fill(this.usersDBAppDataCus.tblReg);

        }

        private void btnmax_Click(object sender, EventArgs e)
        {

        }
    }
}
