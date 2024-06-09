using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_HDNhap : Connection
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable get_pt()
        {
            cmd = new SqlCommand();
            oppen();
            da = new SqlDataAdapter("Select * from gd_pt", conn);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        void thucthiSQL(string sql, DTO_HDNhap pt, int id)
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
            cmd.Parameters.Add(new SqlParameter("@id", id));
            cmd.ExecuteNonQuery();
            close();
        }
        public bool them(DTO_HDNhap pt,int id)
        {
            string sql_them = "insert into gd_pt values(@hinhanh, @ten_pt, @soluong, @gia, @ngaynhap, @noi_cung_cap, @tinhtrang, @id)";
            thucthiSQL(sql_them, pt,id);
            return true;
        }
        public bool sua(DTO_HDNhap pt, int id)
        {
            string sql_sua = "update gd_pt set hinhanh=@hinhanh, ten_pt = @ten_pt, gia=@gia, soluong = @soluong, noi_cung_cap = @noi_cung_cap, tinhtrang= @tinhtrang where id = '" + id + "'";
            thucthiSQL(sql_sua, pt, id);
            return true;
        }
        public bool xoa(int id)
        {
            oppen();
            cmd = new SqlCommand("delete from gd_pt where id = @id", conn);
            cmd.Parameters.Add(new SqlParameter("@id", id));
            cmd.ExecuteNonQuery();
            close();
            return true;
        }
    }
}
