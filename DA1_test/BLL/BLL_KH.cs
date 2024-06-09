using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class BLL_KH
    {
        DAL_Khachang khachhang = new DAL_Khachang();
        public DataTable getKhachang()
        {
            return khachhang.getKhachhang();
        }
        public bool check_tt(string ten, string diachi, int tuoi, string gioitinh)
        {
            if(ten == "" || diachi == "" ||  tuoi<18||gioitinh == "") { 
            
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
                return false;
            }
            else
            {
                return true ;
            }
        }
        public bool themKH(DTO_Khachhang kh)
        {
            return khachhang.them(kh);
        }
        public bool suaKH(DTO_Khachhang kh, int id)
        {
             return khachhang.sua(kh, id);
        }
        public bool  xoaKH(int id)
        {
            return  khachhang.xoa(id);
        }

        public DataTable get_Xe(int id)
        {
            return khachhang.get_xe(id);
        }
        public DataTable get_BSX(int id) { 
            return khachhang.get_bsx(id);   
        }

        public DataTable get_DV() { 
            return khachhang.get_dv();  
        }
        public DataTable get_NS() { 
            return khachhang.get_ns();
        }
       
        public int get_Count()
        {
            return khachhang.getCount();
        }
        
    }
}
