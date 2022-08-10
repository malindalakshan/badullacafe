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
    public partial class SystemLoading : Form
    {
        public SystemLoading()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }


        int openbar = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            openbar += 1;
            progressBar1.Value = openbar;

            if (progressBar1.Value == 100 )
            {
                progressBar1.Value = 0;
                timer1.Stop();

                Selectrole home = new Selectrole();
                home.Show();
                this.Hide();

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
           
            
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Minimized;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
