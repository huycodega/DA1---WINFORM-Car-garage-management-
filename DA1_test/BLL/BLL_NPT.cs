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
    public class BLL_NPT
    {
        DAL_NPT NPT = new DAL_NPT();    
        public DataTable get_NPT()
        {
            return NPT.get_npt();
        }
        public bool them_NPT(DTO_NPT npt)
        {
            return NPT.them(npt);
        }
        public bool sua_NPT(DTO_NPT npt, int id)
        {
            return  NPT.sua(npt, id);
        }
        public bool xoa_NPT(int id)
        {
            return NPT.xoa(id); 
        }
        public int get_Count()
        {
            return NPT.get_count();
        }
        public DataTable get_Ten(int id) { 
            return NPT.get_ten(id); 
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
        public DataTable get_Ma()
        {
            return NPT.get_ma();
        }
    }
}
