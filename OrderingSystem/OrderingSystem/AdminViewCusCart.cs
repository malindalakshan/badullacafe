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
    public partial class AdminViewCusCart : Form
    {
        public AdminViewCusCart()
        {
            InitializeComponent();
        }

        private void AdminViewCusCart_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersDBtblorCusDataApp.tblorcus' table. You can move, or remove it, as needed.
            this.tblorcusTableAdapter.Fill(this.usersDBtblorCusDataApp.tblorcus);


        }

        private void button27_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminDash bakaview = new AdminDash();
            bakaview.Show();
            this.Hide();
        }

        private void btncuscartRe_Click(object sender, EventArgs e)
        {
            try
            {
                RegConnect up = new RegConnect();
                up.conn.ConnectionString = up.locate;
                up.conn.Open();
                string updatecart = "select * from tblorcus ";
                tblorcusTableAdapter.Update(usersDBtblorCusDataApp.tblorcus);
                SqlDataAdapter sa = new SqlDataAdapter(updatecart, up.locate);
                DataSet ds = new System.Data.DataSet();
                sa.Fill(ds, "tblcartView");
                cuscartviewdb.DataSource = ds.Tables[0];

                MessageBox.Show("Updated", "Done", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
    }
}
