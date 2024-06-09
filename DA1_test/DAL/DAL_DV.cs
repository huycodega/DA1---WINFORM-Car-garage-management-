using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_DV : Connection
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable get_dv()
        {
            cmd = new SqlCommand();
            oppen();
            da = new SqlDataAdapter("select * from dichvu", conn);
            dt = new DataTable();
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
        public bool them(DTO_DV dv)
        {
            string sql_them = "insert into dichvu values(N'" + dv.ten_dv + "', '" + dv.gia + "')";
            thucthiSQL (sql_them);  
            return true;
        }
        public bool sua(DTO_DV dv, int id)
        {
            string sql_sua = "update dichvu set ten_dv = N'" + dv.ten_dv + "', gia = '" + dv.gia + "' where id = '" + id + "'";
            thucthiSQL(sql_sua);
            return true;    
        }
        public bool xoa(int id)
        {
            string sql_xoa = "delete dichvu where id= '" + id + "'";
            thucthiSQL(sql_xoa);
            return true;
        }
        public DataTable gia_dv(string dv)
        {
            cmd = new SqlCommand(); 
            oppen();
            SqlDataAdapter da_gia = new SqlDataAdapter("select gia from dichvu where ten_dv = N'"+dv+"'", conn);
            DataTable dt_gia = new DataTable(); 
            da_gia.Fill(dt_gia);
            return dt_gia;  
        }
        public DataTable get_id(string dv)
        {
            cmd = new SqlCommand();
            oppen();
            SqlDataAdapter da_id = new SqlDataAdapter("select id from dichvu where ten_dv = N'" + dv + "'", conn);
            DataTable dt_id = new DataTable();
            da_id.Fill(dt_id);
            return dt_id;
        }
        public int get_count()
        {
            return dt.Rows.Count;
        }
    }
}
