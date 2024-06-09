using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BLL
{
    public class BLL_BangCong
    {
        DAL_BangCong bangcong = new DAL_BangCong(); 
        public DataTable get_BC()
        {
            return bangcong.get_bangcong();
        }
        public bool them_BC(DTO_BangCong bc)
        {
            return bangcong.them(bc);
        }
        public bool xoa_BC(int id)
        {
            return bangcong.xoa(id);
        }
    }
}
