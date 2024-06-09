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
    public class DAL_NPT : Connection
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable get_npt()
        {
            cmd = new SqlCommand();
            oppen();
            da = new SqlDataAdapter("Select * from nhom_pt",conn);
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
        public bool them(DTO_NPT npt)
        {
            string sql_them = "insert into nhom_pt values(N'" + npt.ten + "')";
            thucthiSQL (sql_them);  
            return true;
        }
        public bool sua(DTO_NPT npt, int id)
        {
            string sql_sua = "Update nhom_pt set ten_nhom = '" + npt.ten + "' where id = '" + id + "'";
            thucthiSQL(sql_sua);
            return true;
        }
        public bool xoa(int id)
        {
            string sql_xoa = "Delete nhom_pt where id = '" + id + "'";
            thucthiSQL(sql_xoa);
            return true;    
        }
        public DataTable get_ten(int id)
        {
            cmd = new SqlCommand();
            oppen();
            SqlDataAdapter da_ten = new SqlDataAdapter("select ten_nhom from nhom_pt where id = '" + id + "'", conn);
            DataTable dt_ten = new DataTable(); 
            da_ten.Fill(dt_ten);    
            close();    
            return dt_ten;
        }

        public DataTable get_ma()
        {
            cmd = new SqlCommand();
            oppen();
            SqlDataAdapter da_ma = new SqlDataAdapter("select id from nhom_pt", conn);
            DataTable dt_ma = new DataTable();  
            da_ma.Fill(dt_ma);
            close();
            return dt_ma;
        }
        public int get_count()
        {
            return dt.Rows.Count;
        }
    }
}
