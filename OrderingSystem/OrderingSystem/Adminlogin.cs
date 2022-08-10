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
    public partial class Adminlogin : Form
    {
        public Adminlogin()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Enter Username And Password","Alert!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox1.Text == "Admin" && textBox2.Text == "1234")
            {
                AdminDash logad = new AdminDash();
                logad.Show();
                this.Hide();
            }
            else if (textBox1.Text == "Admin" && textBox2.Text == "")
            {
                MessageBox.Show("Please Enter Correct Password");
            }
            else if (textBox1.Text == "" && textBox2.Text == "1234")
            {
                MessageBox.Show("Please Enter Correct Username");
            }
            else if (textBox1.Text != "Admin" || textBox2.Text != "1234")
            {
                MessageBox.Show("Please check the Username or Password","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '.';
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btnmax_Click(object sender, EventArgs e)
        {
            Selectrole dash = new Selectrole();
            dash.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
