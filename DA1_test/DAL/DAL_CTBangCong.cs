using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_CTBangCong : Connection
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable get_ctbc(int id)
        {
            cmd = new SqlCommand();
            oppen();
            da = new SqlDataAdapter("select*from chitietchamcong where id_bangcong = '"+id+"'", conn);
            dt = new DataTable();
            da.Fill(dt);    
            return dt;
        }
        void thucthiSQL(string sql)
        {
            oppen();
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            close();
        }
        public bool them_thongtin(DTO_CTBangCong ct)
        {
            string sql_themtt = "insert into chitietchamcong (id_bangcong, id_nhanvien, hoten,ngaycong, ngayphep, tongngaycong) values ('" + ct.id_bangcong + "', '" + ct.nhanvien + "', '" + ct.hoten + "',  '" + ct.ngaycong + "', '" + ct.ngayphep + "', '" + ct.tongngaycong + "')";
            thucthiSQL (sql_themtt);    
            return true;    
        }
        public bool them_ngay (int ngay)
        {
            string sql_themngay = "insert into chitietchamcong (d"+ngay.ToString()+") values ('X')" ;
            thucthiSQL(sql_themngay);
            return true;
        }
    }
}
