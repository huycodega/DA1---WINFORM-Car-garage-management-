using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_LoiNhuan: Connection
    {
        
        public DataTable get_ln(int thang , int nam)
        {
            SqlCommand cmd;
            SqlDataAdapter da;
            DataTable dt;
            cmd = new SqlCommand();
            oppen();
            cmd.CommandText = "sp_CalculateDoanhThu";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@Month", thang);
            cmd.Parameters.AddWithValue("@Year", nam);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable get_ln_thang(int thang ) {
            SqlCommand cmd;
            SqlDataAdapter da;
            DataTable dt;
            cmd = new SqlCommand();
            oppen();
            cmd.CommandText = "sp_CalculateDoanhThu";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@Month", thang);
            
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable get_ln_nam(int nam )
        {
            SqlCommand cmd;
            SqlDataAdapter da;
            DataTable dt;
            cmd = new SqlCommand();
            oppen();
            cmd.CommandText = "sp_CalculateDoanhThu";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;           
            cmd.Parameters.AddWithValue("@Year", nam);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
