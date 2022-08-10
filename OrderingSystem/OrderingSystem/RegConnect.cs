using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OrderingSystem
{
    internal class RegConnect
    {
        public SqlConnection conn = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public string locate = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\project\OrderingSystem\OrderingSystem\UsersDB.mdf';Integrated Security=True";

        internal bool Read()
        {
            throw new NotImplementedException();
        }
    }
}
