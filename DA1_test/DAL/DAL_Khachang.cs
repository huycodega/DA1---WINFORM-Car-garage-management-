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
    public class DAL_Khachang:Connection
    {
        SqlCommand _command;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable getKhachhang()
        {
            _command = new SqlCommand();
            oppen();
            da = new SqlDataAdapter("select * from khachhang", conn);
            dt = new DataTable();
            da.Fill(dt);
            close();
            return dt;
        }
        void thucthiSQL(string sql)
        {
            oppen();
            _command = new SqlCommand(sql, conn);
            _command.ExecuteNonQuery();
            close();
        }

        public bool them(DTO_Khachhang kh)
        {
            
            string sql = "insert into khachhang values(N'" + kh.ten + "', '" + kh.tuoi + "', N'" + kh.diachi + "',N'" + kh.gioi_tinh + "','"+kh.sdt+"')";
            thucthiSQL(sql);
            return true;
        }
        public bool sua(DTO_Khachhang kh, int id)
        {
            string sql_sua = "Update khachhang set ten=N'" + kh.ten + "', tuoi='"+kh.tuoi+"', gioitinh = N'"+kh.gioi_tinh+"', diachi = N'"+kh.diachi+"', sdt = '"+kh.sdt+"' where id = '"+id+"'";
            thucthiSQL(sql_sua);
            return true;
        }
        public bool xoa(int id)
        {
            string sql_xoa = "delete from khachhang where id='" + id + "'";
            thucthiSQL(sql_xoa);
            return true;
        }

        public DataTable get_xe(int id)
        {
            _command = new SqlCommand();
            oppen();
            SqlDataAdapter da_xe = new SqlDataAdapter("select id, ten_xe from xe where id_kh = '"+id+"'",conn);
            DataTable dt_xe = new DataTable();  
            da_xe.Fill(dt_xe);
            close();
            return dt_xe;   
        }
        public DataTable get_bsx(int id)
        {
            _command = new SqlCommand();
            oppen();
            SqlDataAdapter da_bs = new SqlDataAdapter("select bienso from xe where id = '" + id + "'", conn);
            DataTable dt_bs = new DataTable();  
            da_bs.Fill(dt_bs);
            close();
            return dt_bs;
        }
        public DataTable get_dv()
        {
            _command = new SqlCommand();
            oppen();
            SqlDataAdapter da_dv = new SqlDataAdapter("select id, ten_dv from dichvu", conn);
            DataTable dt_dv = new DataTable();  
            da_dv.Fill(dt_dv);  
            close();
            return dt_dv;
        }
        public DataTable get_ns()
        {
            _command = new SqlCommand();
            oppen();
            SqlDataAdapter da_ns = new SqlDataAdapter("select id, ten_ns from nhansu", conn);
            DataTable dt_ns = new DataTable();  
            da_ns.Fill(dt_ns);
            close();
            return dt_ns;
        }
        
        public int getCount()
        {
            return dt.Rows.Count;
        }

    }
}
