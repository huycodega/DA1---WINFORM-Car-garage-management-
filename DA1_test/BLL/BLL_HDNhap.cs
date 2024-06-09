using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_HDNhap
    {
        DAL_HDNhap ptung = new DAL_HDNhap();
        public DataTable get_PhuTung()
        {
            return ptung.get_pt();
        }
        public bool them_pt(DTO_HDNhap pt, int id)
        {
            return ptung.them(pt,id);
        }
        public bool sua_pt(DTO_HDNhap pt, int id)
        {
            return ptung.sua(pt, id);
        }
        public bool xoa_pt(int id)
        {
            return ptung.xoa(id);
        }
    }
}
