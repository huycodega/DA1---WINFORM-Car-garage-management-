using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLL_TKPT
    {
        DAL_TKPT tkpt = new DAL_TKPT();
        public DataTable get_TKPT(int thang, int nam)
        {
            if(thang!=0 && nam != 0)
            {
                return tkpt.get_tkpt(thang, nam);
            }
            else
            {
                return tkpt.get_tkpt_nam(nam);
            }
        }
    }
}
