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
    public partial class Costomerlogin : Form
    {
        public Costomerlogin()
        {
            InitializeComponent();
        }
        
        private void Costomerlogin_Load(object sender, EventArgs e)
        {

        }
 
        private void cusCreate_Click(object sender, EventArgs e)
        {
            CustomercusReg regcus = new CustomercusReg();
            regcus.Show();  
            this.Hide();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (txtuse.Text != "" && txtp.Text != "")
            {
                try
                {
                    RegConnect obj = new RegConnect();
                    obj.conn.ConnectionString = obj.locate;

                    obj.conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT COUNT (*) FROM tblReg WHERE username = '" + txtuse.Text + "' and password = '" + txtp.Text + "' ", obj.conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    

                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        MessageBox.Show("Successfully Login!!","Done",MessageBoxButtons.OK,MessageBoxIcon.Information);
                     
                        CustomercusCart log = new CustomercusCart();
                        log.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("User name or Password Incorrect!!");
                    }
                    obj.conn.Close();

                }
                catch(Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("No Empty fileds are allowed", "Alert!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtp.PasswordChar = '\0';
               
            }
            else
            {
                txtp.PasswordChar = '*';
                
            }
        }

        private void txtclearcus_Click(object sender, EventArgs e)
        {
            txtp.Clear();
            txtuse.Clear();
        }


        private void btnmax_Click(object sender, EventArgs e)
        {
            Selectrole selectrole = new Selectrole();
            selectrole.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
