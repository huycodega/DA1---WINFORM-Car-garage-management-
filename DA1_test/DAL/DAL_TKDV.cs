using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_TKDV :Connection
    {
        
        public DataTable get_dvsd(int thang, int nam)
        {
            SqlDataAdapter da;
            SqlCommand cmd;
            DataTable dt;
            string thucthi = "SELECT dichvu, count(chi_tiet_hoa_don.dichvu) AS 'sudung' FROM chi_tiet_hoa_don where month(ngay) = '" + thang + "' and YEAR(ngay) = '" + nam + "' GROUP BY dichvu,MONTH(ngay), year(ngay)";
            cmd = new SqlCommand();
            oppen();
            da = new SqlDataAdapter(thucthi,conn);
            dt = new DataTable();   
            da.Fill(dt);
            return dt;
        }
        public DataTable get_dvsd_nam(int nam) {
            SqlDataAdapter da;
            SqlCommand cmd;
            DataTable dt;
            string thucthi = "SELECT dichvu, count(chi_tiet_hoa_don.dichvu) AS 'sudung' FROM chi_tiet_hoa_don where YEAR(ngay) = '" + nam + "' GROUP BY dichvu,MONTH(ngay), year(ngay)";
            cmd = new SqlCommand();
            oppen();
            da = new SqlDataAdapter(thucthi, conn);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
