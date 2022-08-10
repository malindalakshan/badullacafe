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
    public partial class Cuscartpro : Form
       
    {
        int index;
      

        public Cuscartpro()
        {
            InitializeComponent();
        }

        
        private void btnmax_Click(object sender, EventArgs e)
        {
            CustomercusCart pro = new CustomercusCart();
            pro.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cartpro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersDBtblorCusDataApp.tblorcus' table. You can move, or remove it, as needed.
            this.tblorcusTableAdapter.Fill(this.usersDBtblorCusDataApp.tblorcus);
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
                tblorCUS.DataSource = ds.Tables[0];

                MessageBox.Show("Updated", "Done", MessageBoxButtons.OK);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }


       


        private void btnDELE_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("If You Want Delete This Account?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    RegConnect de = new RegConnect();
                    de.conn.ConnectionString = de.locate;
                    de.conn.Open();
                    string deletefood = "delete from tblorcus ";
                    de.cmd.Connection = de.conn;
                    de.cmd.CommandText = deletefood;
               
                    de.cmd.ExecuteNonQuery();

                    de.conn.Close();


                    MessageBox.Show("Delete has been completed", "Done", MessageBoxButtons.OK);

                    tblorcusBindingSource.RemoveCurrent();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            index = tblorCUS.CurrentCell.RowIndex;
            tblorCUS.Rows.RemoveAt(index);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            CustomerPay pay = new CustomerPay();
            pay.fdprice = txtcusfoodview.Text;
            pay.Show();
           
            this.Hide();
            

        }




         public void SelecteRowTotal()
          {
         double sum  = 0;
           for (int i = 0; i < tblorCUS.Rows.Count; i++)
           {
        if(Convert.ToBoolean(tblorCUS.Rows[i].Cells[0].Value) == true)

                   sum += double.Parse(tblorCUS.Rows[i].Cells[6].Value.ToString()); 
                    //sum += double.Parse(CuscartView.Rows[i].Cells[5].Value.ToString());
                    
                }
            txtcusfoodview.Text = sum.ToString();
        }
         



          private void btnSum_Click(object sender, EventArgs e)
        {
            SelecteRowTotal();
        }

        private void tblorCUS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSum.PerformClick();
        }
    }
}

