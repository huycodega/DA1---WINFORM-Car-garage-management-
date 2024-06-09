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
    public class DAL_NhanSu : Connection
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable get_Nhansu()
        {
            cmd = new SqlCommand(); 
            oppen();
            da = new SqlDataAdapter("Select * from nhansu",conn);
            dt = new DataTable();   
            da.Fill(dt);
            return dt;
        }
        void thucthiSQL(string sql, DTO_NhanSu ns)
        {
            string ngay = string.Format("{0}/{1}/{2}", ns.ngay_sinh.Year, ns.ngay_sinh.Month, ns.ngay_sinh.Day);
            oppen();
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter("@hinhanh",ns.hinhanh));
            cmd.Parameters.Add(new SqlParameter("@ten_ns", ns.ten_ns));
            cmd.Parameters.Add(new SqlParameter("@gioi_tinh", ns.gioitinh));
            cmd.Parameters.Add(new SqlParameter("@ngay_sinh", ngay));
            cmd.Parameters.Add(new SqlParameter("@dc_ns", ns.dc_ns));
            cmd.Parameters.Add(new SqlParameter("@sdt", ns.sdt));
            cmd.Parameters.Add(new SqlParameter("@chuc_vu", ns.chuc_vu));
            cmd.ExecuteNonQuery();
            close();
        }
        public bool them(DTO_NhanSu ns)
        {

            string sql_them = "insert into nhansu values(@hinhanh, @ten_ns, @gioi_tinh, @ngay_sinh, @dc_ns, @sdt, @chuc_vu)";
            thucthiSQL(sql_them,ns);
            return true;
        }
        public bool sua(DTO_NhanSu ns, int id)
        {
            string sql_them = "update nhansu set hinhanh = @hinhanh, ten_ns=@ten_ns, gioi_tinh = @gioi_tinh, ngay_sinh = @ngay_sinh, dc_ns = @dc_ns, sdt = @sdt, chuc_vu = @chuc_vu where id = '"+id+"'";
            thucthiSQL(sql_them,ns);
            return true;
        }
        public bool xoa(int id)
        {
            oppen();
            cmd = new SqlCommand("delete from nhansu where id = @id", conn);
            cmd.Parameters.Add(new SqlParameter("@id", id));
            cmd.ExecuteNonQuery();
            close();
            return true;
        }
        public int get_count()
        {
            return dt.Rows.Count;
        }
    }
}
