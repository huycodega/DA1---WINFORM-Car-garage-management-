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
    public class DAL_CTHoaDon : Connection
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable get_cthd()
        {
            cmd = new SqlCommand();
            oppen();
            da = new SqlDataAdapter("select ten_kh, ten_xe, bxe, dichvu, soluong_pt, tong_gia, tt_thanhtoan, ngay from chi_tiet_hoa_don", conn);
            dt = new DataTable();
            da.Fill(dt);    
            return dt;
        }
        public DataTable getid()
        {
            cmd = new SqlCommand();
            oppen();
            da = new SqlDataAdapter("select id from chi_tiet_hoa_don", conn);
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
        public bool them(DTO_CTHoaDon cthd, int id_kh)
        {
            string sql_them = "insert into chi_tiet_hoa_don values(N'" + cthd.ten_kh + "', '" + cthd.ten_xe + "', '" + cthd.bsx + "', N'" + cthd.dichvu + "', '" + cthd.slphutung + "', '" + cthd.tonggia + "', N'" + cthd.tt_thanhtoan + "', '" + cthd.ngay + "', '" + id_kh + "')";
            thucthiSQL(sql_them);
            return true;
        }
        public bool sua (DTO_CTHoaDon cthd, int id)
        {
            string sql_sua = "update chi_tiet_hoa_don set ten_kh = N'" + cthd.ten_kh + "', ten_xe = '" + cthd.ten_xe + "', bxe = '" + cthd.bsx + "', dichvu = '" + cthd.dichvu + "', soluong_pt = '" + cthd.slphutung + "', tong_gia ='" + cthd.tonggia + "', tt_thanhtoan = '" + cthd.tt_thanhtoan + "' where id = '" + id + "'";
            thucthiSQL (sql_sua);   
            return true;    
        }
        public bool xoa(int id)
        {
            
            string sql_xoa = "delete chi_tiet_hoa_don where id = '" + id + "'";
            thucthiSQL(sql_xoa);
            return true;
        }
        public DataTable get_idmax()
        {
            cmd = new SqlCommand();
            oppen();
            SqlDataAdapter da_max = new SqlDataAdapter("select id from chi_tiet_hoa_don order by(id) desc",conn);
            DataTable dt_max = new DataTable();
            da_max.Fill(dt_max);
            return dt_max;  
        }
        public int get_count()
        {
            return dt.Rows.Count;
        }
    }
}
