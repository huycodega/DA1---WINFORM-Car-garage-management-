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
    public class DAL_CTHDKH : Connection
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable get_cthdkh(int id)
        {
            cmd = new SqlCommand();
            oppen();
            da = new SqlDataAdapter("select ten_pt, soluong,gia from chitiet_hd_khachhang where id_ct = '"+id+"' ", conn);
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
        public bool them(DTO_CTHDKH cthdkh, int id_pt, int id_phieu)
        {
            string sql_them = "insert into chitiet_hd_khachhang values('" + cthdkh.ten_pt + "', '" + cthdkh.soluong + "', '" + cthdkh.gia + "', '"+id_pt+"', '"+id_phieu+"')";
            thucthiSQL (sql_them);  
            return true;
        }
    }
}
