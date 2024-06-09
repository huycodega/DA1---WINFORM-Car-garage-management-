using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Connection
    {
        string con = @"Data Source=MSI;Initial Catalog=gara_oto;Integrated Security=True;TrustServerCertificate=True";
        protected SqlConnection conn = null;
        public void oppen()
        {
            conn = new SqlConnection(con);
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }
        public void close()
        {
            if (conn.State != ConnectionState.Closed)
            {

                conn.Close();
                conn.Dispose();
            }
        }
    }
}
