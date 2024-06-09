using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_DV
    {
        DAL_DV DV = new DAL_DV();   
        public DataTable get_DV()
        {
            return DV.get_dv();
        }
        public bool them_DV(DTO_DV dv)
        {
            return DV.them(dv);
        }
        public bool sua_DV(DTO_DV dv, int id)
        {
            return DV.sua(dv, id);  
        }
        public bool xoa_DV(int id)
        {
            return DV.xoa(id);
        }
        public DataTable get_Gia(string ten)
        {
            return DV.gia_dv(ten);
        }
        public DataTable get_ID(string id)
        {
            return DV.get_id(id);
        }
        public bool check_tt(string ten)
        {
            if(ten == "")
            {
                return false;
            }
            else
            {
                return true;    
            }
        }
        public int get_Count()
        {
            return DV.get_count();
        }
    }
}
