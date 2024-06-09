using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLL_LoiNhuan
    {
        DAL_LoiNhuan loinhuan = new DAL_LoiNhuan();
        public DataTable get_LN (int thang, int nam)
        {
            if(thang != 0 && nam != 0)
            {
                return loinhuan.get_ln(thang, nam);
            }
            else if(thang == 0 &&nam != 0)
            {
                return loinhuan.get_ln_nam(nam);
            }
            else
            {
                return loinhuan.get_ln_thang(thang);  
            }
        }
        
    }
}
