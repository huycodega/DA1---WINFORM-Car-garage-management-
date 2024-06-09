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
    public class DAL_PhieuLL : Connection
    {
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter da;
        public DataTable get_phieu()
        {
            cmd = new SqlCommand();
            oppen();
            da = new SqlDataAdapter("select id, id_kh, ten_kh, tuoi, diachi, sdt, ten_xe, bxe, nguoi_lam_viec, dichvu, ngay_hen, tt_thanhtoan from phieu_lap_lich", conn);
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
        public bool them(DTO_PhieuLL phieu, int id_kh, int id_ns, int id_dv)
        {
            string tt = "Chưa thanh toán";
            string ngay = string.Format("{0}/{1}/{2}", phieu.ngay_hen.Year, phieu.ngay_hen.Month, phieu.ngay_hen.Day);
            string sql_them = "insert into phieu_lap_lich values(N'" + phieu.ten_kh + "', '"+phieu.tuoi+"','"+phieu.diachi+"', '"+phieu.sdt+"', '" + phieu.ten_xe + "', '" + phieu.bienso + "', N'" + phieu.nguoi_lam_viec + "', N'" + phieu.dichvu + "', '" + ngay + "', N'"+tt+"', '" + id_kh + "', '" + id_ns + "', '"+id_dv+"')";
            thucthiSQL(sql_them);
            return true;
        }
        public bool sua(DTO_PhieuLL phieu, int id_kh, int id_ns, int id)
        {
            string tinhtrang = "Chưa thanh toán";
            string ngay = string.Format("{0}/{1}/{2}", phieu.ngay_hen.Year, phieu.ngay_hen.Month, phieu.ngay_hen.Day);
            string sql_sua = "update phieu_lap_lich set ten_kh = N'"+phieu.ten_kh+"', tuoi = '"+phieu.tuoi+"',  ten_xe = '"+phieu.ten_xe+"', bxe = '"+phieu.bienso+"', nguoi_lam_viec = N'"+phieu.nguoi_lam_viec+"', dichvu = N'"+phieu.dichvu+"', ngay_hen = '"+ngay+"', tt_thanhtoan = N'"+tinhtrang+"', id_kh = '"+id_kh+"', id_ns = '"+id_ns+"' where id = '"+id+"'";
            thucthiSQL(sql_sua);
            return true;    
        }
        public bool xoa(int id)
        {
            string sql_xoa = "delete phieu_lap_lich where id = '" + id + "'";
            thucthiSQL(sql_xoa);
            return true;
        }
        public bool sua_thanhtoan(string tt, int id_kh, int id )
        {
            string tt_thanhtona = "Đã thanh toán";
            string sql_suatt = "update phieu_lap_lich set tt_thanhtoan = N'" + tt_thanhtona + "' where tt_thanhtoan = N'" + tt + "' and id_kh = '"+id_kh+"' and id = '"+id+"'";
            thucthiSQL(sql_suatt);  
            return true;
        }
        public int get_count()
        {
            return dt.Rows.Count;
        }
    }
}
