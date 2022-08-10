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
    public partial class AdminviewCusFeed : Form
    {
        public AdminviewCusFeed()
        {
            InitializeComponent();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminDash adbackfeed = new AdminDash();
            adbackfeed.Show();
            this.Hide();
        }

        private void viewCusFeed_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersDBFeedAppData.tblfeed' table. You can move, or remove it, as needed.
            this.tblfeedTableAdapter.Fill(this.usersDBFeedAppData.tblfeed);
            // TODO: This line of code loads data into the 'usersDBFeedAppData.tblfeed' table. You can move, or remove it, as needed.
            this.tblfeedTableAdapter.Fill(this.usersDBFeedAppData.tblfeed);
            // TODO: This line of code loads data into the 'usersDBFeedAppData.tblfeed' table. You can move, or remove it, as needed.
            this.tblfeedTableAdapter.Fill(this.usersDBFeedAppData.tblfeed);
            // TODO: This line of code loads data into the 'usersDBFeedAppData.tblfeed' table. You can move, or remove it, as needed.
            this.tblfeedTableAdapter.Fill(this.usersDBFeedAppData.tblfeed);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cuscartviewdb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
