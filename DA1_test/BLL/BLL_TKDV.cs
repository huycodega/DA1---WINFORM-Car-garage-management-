using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
    public class BLL_TKDV
    {
        DAL_TKDV tkdv = new DAL_TKDV(); 
        public DataTable get_TKDV(int thang, int nam)
        {
            if (thang != 0 && nam != 0)
            {
                return tkdv.get_dvsd(thang, nam);
            }
            else
            {
                return tkdv.get_dvsd_nam(nam);  
            }   
        }
    }
}
