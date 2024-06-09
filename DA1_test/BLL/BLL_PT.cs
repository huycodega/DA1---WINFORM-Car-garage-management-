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
    public class BLL_PT
    {
        DAL_PT ptung = new DAL_PT();
        public DataTable get_PhuTung()
        {
            return ptung.get_pt();
        }
        public bool them_pt(DTO_PT pt)
        {
            return ptung.them(pt);
        }
        public bool sua_pt(DTO_PT pt, int id)
        {
            return ptung.sua(pt, id);
        }
        public bool xoa_pt(int  id)
        {
            return ptung.xoa(id);   
        }
        public DataTable get_Cbo()
        {
            return ptung.get_cbo();
        }

        public DataTable get_CTNPT( int id)
        {
            return ptung.get_ctnpt(id);
        }

        public bool them_CT(DTO_PT pt, int id_nhom, int id_pt)
        {
            return ptung.them_ct(pt, id_nhom, id_pt);
        }
        public bool xoa_CT(int id_pt)
        {
            return ptung.xoa_ct(id_pt); 
        }
        public DataTable get_Gia(int id)
        {
            return ptung.get_gia(id);   
        }
        public DataTable get_SL(int id)
        {
            return ptung.get_sl(id);   
        }
        public bool sua_SL(int id, int sl)
        {
            return ptung.update_sl(id, sl);
        }
        public DataTable get_IDmax()
        {
            return ptung.get_idmax();
        }
        public DataTable get_ID(string ten) { 
            return ptung.get_id(ten);   
        }
        public bool check_tt(string ten, string sl, string gia, string noicc)
        {
            if (ten == "" || sl == "" || gia == "" || noicc == "" )
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public DataTable get_hangcong() {
            return ptung.get_conhang();
        }
        public bool sua_TT()
        {
            return ptung.trangthai();
        }
        public int get_Count()
        {
            return ptung.get_count();
        }
        public DataTable get_Find(int id) { 
            return ptung.get_find(id);  
        }
    }
}
