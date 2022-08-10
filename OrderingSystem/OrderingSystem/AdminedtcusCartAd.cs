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
    public partial class AdminedtcusCartAd : Form
    {
        public AdminedtcusCartAd()
        {
            InitializeComponent();
        }

        private void edtcusCartAd_Load(object sender, EventArgs e)
        {

            this.tblcusCartTableAdapter.Fill(this.usersDBAppDataAdminCartView.tblcusCart);
            Changename(false);

        }

        private void button27_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminDash goback = new AdminDash();
            goback.Show();
            this.Hide();
        }

        private void CARTadminedt_Click(object sender, EventArgs e)
        {
            Changename(true);
            textBox3.Focus();
        }

        private void CARTadsave_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                tblcusCartBindingSource.EndEdit();
                tblcusCartTableAdapter.Update(this.usersDBAppDataAdminCartView.tblcusCart);

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;
        }

        private void Changename(bool value)
        {
            textBox1.Enabled = value;
            textBox3.Enabled = value;
            textBox2.Enabled = value;

        }

        private void AdaEDTcart_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }  

          
 }
