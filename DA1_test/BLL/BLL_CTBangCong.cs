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
    public class BLL_CTBangCong
    {
        DAL_CTBangCong chitiet = new DAL_CTBangCong();  
        public DataTable get_CT(int id)
        {
            return chitiet.get_ctbc(id);
        }
        public bool them_TT(DTO_CTBangCong ct)
        {
            return chitiet.them_thongtin(ct);
        }
        public bool them_Ngay(int ngay)
        {
            return chitiet.them_ngay(ngay);
        }
    }
}
