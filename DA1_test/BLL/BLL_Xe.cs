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
    public class BLL_Xe
    {
        DAL_Xe car = new DAL_Xe();  
        public DataTable getXe()
        {
            return car.getxe(); 
        }
        public bool themXe(DTO_Xe xe, int id)
        {
            return car.them(xe,id);    
        }
        public bool suaXe(DTO_Xe xe, int id)
        {
            return car.sua(xe,id);
        }
        public bool xoaXe(int id)
        {
            return car.xoa(id); 
        }
        public DataTable get_Cbo() {
            return car.get_cbo();
        }
        public int get_Count()
        {
            return car.get_count();
        }
        public bool check_ttxe(string ten, string chusohuu, string bhx, string tt)
        {
            if(ten == "" &&  chusohuu =="" &&  bhx =="" &&  tt == "")
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
            if (ten == "")
            {
                return false ;
            }
            else
            {
                return true;    
            }
        }
        public void xoaXeKh(int id)
        {
            car.xoa_xekh(id);
        }
        
    }
}
