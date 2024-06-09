using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class BLL_NhanSu
    {
        DAL_NhanSu ns = new DAL_NhanSu();   
        public DataTable get_Nhansu()
        {
            return ns.get_Nhansu();
        }
        public bool them_NS(DTO_NhanSu nsu)
        {
            return ns.them(nsu);
        }
        public bool sua_NS(DTO_NhanSu nsu, int id)
        {
            return ns.sua(nsu, id); 
        }
        public bool xoa_NS(int id)
        {
            return ns.xoa(id);
        }
        public bool check_tt(string ten,  string diachi, string gioitinh, string chucvu) { 
            if(ten == "" || diachi =="" ||  gioitinh =="" ||  chucvu == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool check_update(string ten)
        {
            if(ten == "")
            {
                return false ;
            }
            else
            {
                return true;
            }
        }
        public int get_Count()
        {
            return ns.get_count(); 
        }
    }
}
