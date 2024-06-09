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
    public class BLL_PhieuLL
    {
        DAL_PhieuLL phieu = new DAL_PhieuLL();
        public DataTable get_Phieu()
        {
            return phieu.get_phieu();
        }
        public bool them_Phieu(DTO_PhieuLL pll, int id_kh, int id_ns, int id_dv)
        {
            return phieu.them(pll, id_kh, id_ns, id_dv);
        }
        public bool sua_Phieu(DTO_PhieuLL pll, int id_kh, int id_ns, int id)
        {
            return phieu.sua(pll, id_kh, id_ns, id);
        }
        public bool xoa_Phieu(int id)
        {
            return phieu.xoa(id);
        }
        public bool sua_TTTT(string tt, int id_kh, int id)
        {
            return phieu.sua_thanhtoan(tt, id_kh, id); 
        }
        public int get_Count()
        {
            return phieu.get_count();
        }
    }
}
