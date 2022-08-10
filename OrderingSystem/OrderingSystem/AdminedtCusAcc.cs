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
    public partial class AdminedtCusAcc : Form
    {

        public AdminedtCusAcc()
        {
            InitializeComponent();
        }

        private void edtCusAcc_Load(object sender, EventArgs e)
        {
          
            this.tblRegTableAdapter.Fill(this.usersDBAppDataCus.tblReg);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AdminDash adminDash = new AdminDash();
            adminDash.Show();
            this.Hide();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("If You Want Refresh Database?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    RegConnect ob = new RegConnect();
                    ob.conn.ConnectionString = ob.locate;
                    ob.conn.Open();
                    string upduser = "select * from tblReg ";
                    tblRegTableAdapter.Update(usersDBAppDataCus.tblReg);
                    SqlDataAdapter sda = new SqlDataAdapter(upduser, ob.locate);
                    DataSet ds = new System.Data.DataSet();
                    sda.Fill(ds, "tblReg");
                    dataGridView1.DataSource = ds.Tables[0];


                    MessageBox.Show("Updated", "Done", MessageBoxButtons.OK);

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }

        }

        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("If You Want Delete This Account?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    RegConnect o = new RegConnect();
                    o.conn.ConnectionString = o.locate;
                    o.conn.Open();
                    string deleteuser = "delete from tblReg ";
                    o.cmd.Connection = o.conn;
                    o.cmd.CommandText = deleteuser;
                    o.cmd.ExecuteNonQuery();
                    
                    o.conn.Close();



                    MessageBox.Show("Delete has been completed", "Done", MessageBoxButtons.OK);

                    tblRegBindingSource.RemoveCurrent();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }

        }

        private void txtUserSer_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}



