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
    public class BLL_CTHDKH
    {
        DAL_CTHDKH cthdkh = new DAL_CTHDKH();   
        public DataTable get_P(int id)
        {
            return cthdkh.get_cthdkh(id);
        }
        public bool them_tt(DTO_CTHDKH ct, int id_pt, int id_phieu)
        {
            return cthdkh.them(ct, id_pt, id_phieu);
        }
    }
}
