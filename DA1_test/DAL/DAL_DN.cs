using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DN:Connection
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable get_dn(string tk)
        {
            cmd = new SqlCommand();
            oppen();
            da = new SqlDataAdapter("select matkhau from taikhoandn where taikhoan = '"+tk+"'", conn);
            dt = new DataTable();   
            da.Fill(dt);
            return dt;  
        }
    }
}
