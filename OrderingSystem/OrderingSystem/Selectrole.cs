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
    public partial class Selectrole : Form
    {
        public Selectrole()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void Button1ad_Click(object sender, EventArgs e)
        {
            Adminlogin adlog = new Adminlogin();
            adlog.Show();
            this.Hide();
        }

        private void Button2cus_Click(object sender, EventArgs e)
        {
            Costomerlogin adlog = new Costomerlogin();
            adlog.Show();
            this.Hide();
        }


        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btnmax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
