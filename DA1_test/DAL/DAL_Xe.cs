 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_Xe:Connection
    {
        DataTable dt;
        SqlCommand cmd;
        SqlDataAdapter da;
        public DataTable getxe()
        {
            cmd = new SqlCommand();
            oppen();
            da= new SqlDataAdapter("Select id,ten_xe,bienso, tinh_trang, tt_bhx, chu_so_huu from Xe",conn);
            dt = new DataTable();   
            da.Fill(dt); 
            close();    
            return dt;
        }
        void thucthiSQL(string sql)
        {
            oppen();
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            close();    
        }
        public bool them(DTO_Xe xe, int id_kh)
        {
            string sql_them = "insert into xe values('" + xe.ten_xe + "', '" + xe.bienso + "',N'" + xe.tinh_trang + "',N'" + xe.bhx + "',N'" + xe.chu_so_huu + "', '"+id_kh+"')";
            thucthiSQL (sql_them);  
            return true;
        }
        public bool sua(DTO_Xe xe, int id)
        {
            string sql_sua = "update xe set ten_xe ='" + xe.ten_xe + "', bienso = '" + xe.bienso + "', tinh_trang = N'" + xe.tinh_trang + "', tt_bhx = N'" + xe.bhx + "', chu_so_huu = N'" + xe.chu_so_huu + "' where id = '" + id + "'";
            thucthiSQL(sql_sua);
            return true;
        }
        public bool xoa(int id)
        {
            string sql_xoa = "delete from xe where id = '" + id + "'";
            thucthiSQL (sql_xoa);   

            return true;
        }
        public DataTable get_cbo()
        {
            cmd = new SqlCommand();
            oppen();
            SqlDataAdapter da_cbo = new SqlDataAdapter("Select id,ten from khachhang", conn);
            DataTable dt_cbo = new DataTable();
            da_cbo.Fill(dt_cbo);
            close();
            return dt_cbo;

        }
        public int get_count()
        {
            return dt.Rows.Count;
        }

        public void xoa_xekh(int id)
        {
            string sql = "delete from xe where id_kh = '" + id + "'";
            thucthiSQL (sql);
            
        }
    }
}
