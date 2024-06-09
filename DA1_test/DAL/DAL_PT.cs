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
    public class DAL_PT:Connection
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable get_pt() { 
            cmd = new SqlCommand();
            oppen();
            da = new SqlDataAdapter("Select * from phutung", conn);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        void thucthiSQL(string sql, DTO_PT pt)
        {
            string ngay = string.Format("{0}/{1}/{2}", pt.ngaynhap.Year, pt.ngaynhap.Month, pt.ngaynhap.Day);
            oppen();    
            cmd = new SqlCommand(sql,conn);
            cmd.Parameters.Add(new SqlParameter("@hinhanh", pt.hinhanh));
            cmd.Parameters.Add(new SqlParameter("@ten_pt", pt.ten_pt));
            cmd.Parameters.Add(new SqlParameter("@soluong" , pt.soluong));
            cmd.Parameters.Add(new SqlParameter("@gia", pt.gia));
            cmd.Parameters.Add(new SqlParameter("@ngaynhap", ngay));
            cmd.Parameters.Add(new SqlParameter("@noi_cung_cap", pt.noi_cung_cap));
            cmd.Parameters.Add(new SqlParameter("@tinhtrang", pt.tinhtrang));
            cmd.ExecuteNonQuery();
            close();
        }
        public bool them(DTO_PT pt)
        {
            string sql_them = "insert into phutung values(@hinhanh, @ten_pt, @soluong, @gia, @ngaynhap, @noi_cung_cap, @tinhtrang)";
            thucthiSQL(sql_them, pt);   
            return true;    
        }
        public bool sua(DTO_PT pt, int id)
        {
            string sql_sua = "update phutung set hinhanh=@hinhanh, ten_pt = @ten_pt, gia=@gia, soluong = @soluong, noi_cung_cap = @noi_cung_cap, tinhtrang= @tinhtrang where id = '" + id + "'";
            thucthiSQL(sql_sua, pt);
            return true;
        }
        public bool xoa(int id)
        {
            oppen();
            cmd = new SqlCommand("delete from phutung where id = @id", conn);
            cmd.Parameters.Add(new SqlParameter("@id", id));
            cmd.ExecuteNonQuery();
            close();
            return true;
        }
        public DataTable get_cbo()
        {
            cmd = new SqlCommand();
            oppen();
            SqlDataAdapter da_cbo = new SqlDataAdapter("Select id,ten_nhom from nhom_pt", conn);
            DataTable dt_cbo = new DataTable();
            da_cbo.Fill(dt_cbo);
            close();
            return dt_cbo;
        }
        public DataTable get_ctnpt(int id)
        {
            cmd = new SqlCommand();
            oppen();
            SqlDataAdapter da_ctnpt = new SqlDataAdapter("select hinhanh, ten_pt, ngaynhap, gia, soluong, noi_cung_cap, tinhtrang from ct_nhom_pt where id_nhom = '"+id+"'", conn);
            DataTable dt_ctnpt = new DataTable();
            da_ctnpt.Fill(dt_ctnpt);    
            close();
            return dt_ctnpt;
        }
        void thucthiSQL_CT(string sql, DTO_PT pt, int id_nhom, int id_pt)
        {
            string ngay = string.Format("{0}/{1}/{2}", pt.ngaynhap.Year, pt.ngaynhap.Month, pt.ngaynhap.Day);
            oppen();
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter("@hinhanh", pt.hinhanh));
            cmd.Parameters.Add(new SqlParameter("@ten_pt", pt.ten_pt));
            cmd.Parameters.Add(new SqlParameter("@soluong", pt.soluong));
            cmd.Parameters.Add(new SqlParameter("@gia", pt.gia));
            cmd.Parameters.Add(new SqlParameter("@ngaynhap", ngay));
            cmd.Parameters.Add(new SqlParameter("@noi_cung_cap", pt.noi_cung_cap));
            cmd.Parameters.Add(new SqlParameter("@tinhtrang", pt.tinhtrang));
            cmd.Parameters.Add(new SqlParameter("@id_pt", id_pt));
            cmd.Parameters.Add(new SqlParameter("@id_nhom", id_nhom));
            cmd.ExecuteNonQuery();
            close();
        }
        public bool them_ct(DTO_PT ctpt, int id_nhom,int id_pt)
        {
            string sql_them = "insert into ct_nhom_pt values(@hinhanh, @ten_pt, @soluong, @gia, @ngaynhap, @noi_cung_cap, @tinhtrang, @id_nhom, @id_pt)";
            thucthiSQL_CT(sql_them, ctpt, id_nhom, id_pt);  
            return true;
        }
        public bool xoa_ct(int id_pt)
        {
            oppen();
            cmd = new SqlCommand("delete from ct_nhom_pt where id_pt = @id_pt", conn);
            cmd.Parameters.Add(new SqlParameter("@id_pt", id_pt));
            cmd.ExecuteNonQuery();
            close();
            return true;
        }
        public DataTable get_gia(int id)
        {
            cmd = new SqlCommand();
            oppen();
            SqlDataAdapter da_gia = new SqlDataAdapter("Select id,gia from phutung where id = '"+id+"'", conn);
            DataTable dt_gia = new DataTable();
            da_gia.Fill(dt_gia);
            close();
            return dt_gia;
        }
        public DataTable get_sl(int id)
        {
            cmd = new SqlCommand();
            oppen();
            SqlDataAdapter da_sl = new SqlDataAdapter("Select id,soluong from phutung where id = '" + id + "'", conn);
            DataTable dt_sl = new DataTable();
            da_sl.Fill(dt_sl);
            close();
            return dt_sl;
        }
        void SuaSl(string sql)
        {     
            oppen();
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            close();
        }
        public bool update_sl(int id, int sl)
        {
            string sql_up = "update phutung set soluong = '" + sl + "' where id = '" + id + "' ";
            SuaSl(sql_up);
            return true;
        }
        public bool trangthai()
        {
            string sql_tt = "update phutung set tinhtrang = N'Hết hàng' where soluong = 0";
            SuaSl(sql_tt);
            return true;    
        }
        public DataTable get_idmax()
        {
            cmd = new SqlCommand();
            oppen();
            SqlDataAdapter da_max = new SqlDataAdapter("select id from phutung order by(id) desc", conn);
            DataTable dt_max = new DataTable();
            da_max.Fill(dt_max);
            return dt_max;
        }
        public DataTable get_id(string ten)
        {
            cmd = new SqlCommand();
            oppen();
            SqlDataAdapter da_id = new SqlDataAdapter("select id from phutung where ten_pt = N'" + ten + "'", conn);
            DataTable dt_id = new DataTable();  
            da_id.Fill(dt_id);
            return dt_id;
        }
        public DataTable get_conhang()
        {
            string check = "Còn hàng";
            string thucthi = "select id, ten_pt from phutung where tinhtrang = N'Còn hàng'";
            cmd = new SqlCommand();
            oppen();
            SqlDataAdapter da_conhang = new SqlDataAdapter(thucthi,conn);
            DataTable dt_conhang = new DataTable();
            da_conhang.Fill(dt_conhang);
            return dt_conhang;
        }
        public DataTable get_find(int id)
        {
            cmd = new SqlCommand();
            oppen();
            SqlDataAdapter da_find = new SqlDataAdapter("select *from phutung where id = '"+id+"'",conn);
            DataTable dt_find = new DataTable();
            da_find.Fill(dt_find);
            return dt_find;
        }
        public int get_count()
        {
            return dt.Rows.Count;
        }
    }
}
