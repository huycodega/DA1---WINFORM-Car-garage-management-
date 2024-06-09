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
    public class DAL_BangCong : Connection
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable get_bangcong() {
            cmd = new SqlCommand();
            oppen();
            da = new SqlDataAdapter("select * from chamcong", conn);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        void thucthiSQL(string sql) { 
            oppen();    
            cmd = new SqlCommand(sql,conn);
            cmd.ExecuteNonQuery();
            close();
        }
        public bool them(DTO_BangCong bc)
        {
            string sql_them = "insert into chamcong values('" + bc.thang + "' , '" + bc.nam + "', '" + bc.ngaytinhcong + "', '" + bc.ngaycongtrongthang + "')";
            thucthiSQL(sql_them);
            return true;
        }
        //public bool sua (DTO_BangCong bc, int id)
        //{
            
        //}
        public bool xoa(int id)
        {
            string sql_xoa = "delete chamcong where id = '" + id + "'";
            thucthiSQL(sql_xoa);
            return true;    
        }
    }
}
