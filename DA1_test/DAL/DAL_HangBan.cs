using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_HangBan : Connection
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable get_hangban()
        {
            cmd = new SqlCommand();
            oppen();
            da = new SqlDataAdapter("select * from hang_da_ban", conn);
            da.Fill(dt);
            return dt;
        }
        void thucthiSQL(string sql)
        {
            oppen();
            cmd = new SqlCommand(sql,conn);
            cmd.ExecuteNonQuery();
            close();    
        }
        public bool them(DTO_HangBan hb, int id)
        {
            string sql_them = "insert into hang_da_ban values(N'" + hb.ten_pt + "', '" + hb.so_luong + "', '" + hb.gia + "', '" + hb.ngay + "', '"+id+"')";
            thucthiSQL (sql_them);  
            return true;
        }
    }
}
