using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_TKPT : Connection
    {
        
        public DataTable get_tkpt(int thang, int nam)
        {
            SqlCommand cmd;
            SqlDataAdapter da;
            DataTable dt;
            string pt = "SELECT TOP 5 hang_da_ban.ten_pt, Sum(hang_da_ban.so_luong) AS 'slhangban', hang_da_ban.gia FROM hang_da_ban where MONTH(hang_da_ban.ngay) = '" + thang + "' and YEAR(hang_da_ban.ngay) = '" + nam + "' GROUP BY hang_da_ban.ten_pt, hang_da_ban.gia, MONTH(hang_da_ban.ngay), YEAR(hang_da_ban.ngay)\r\nORDER BY COUNT(*) DESC;";
            cmd = new SqlCommand();
            oppen();
            da = new SqlDataAdapter(pt,conn);
            dt = new DataTable();   
            da.Fill(dt);
            return dt;  
            
        }
        public DataTable get_tkpt_nam(int nam)
        {
            SqlCommand cmd;
            SqlDataAdapter da;
            DataTable dt;
            string pt = "SELECT TOP 5 hang_da_ban.ten_pt, Sum(hang_da_ban.so_luong) AS 'slhangban', hang_da_ban.gia FROM hang_da_ban where YEAR(hang_da_ban.ngay) = '" + nam + "' GROUP BY hang_da_ban.ten_pt, hang_da_ban.gia, MONTH(hang_da_ban.ngay), YEAR(hang_da_ban.ngay)\r\nORDER BY COUNT(*) DESC;";
            cmd = new SqlCommand();
            oppen();
            da = new SqlDataAdapter(pt, conn);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
