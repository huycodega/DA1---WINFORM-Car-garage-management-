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
    public class BLL_CTHoaDon
    {
        DAL_CTHoaDon chitiet = new DAL_CTHoaDon();  
        public DataTable get_CTHD()
        {
            return chitiet.get_cthd();
        }
        public bool them_CTHD(DTO_CTHoaDon ct, int id_kh)
        {
            return chitiet.them(ct, id_kh);
        }
        public bool sua_CTHD(DTO_CTHoaDon ct, int id_kh)
        {
            return chitiet.sua(ct, id_kh);  
        }
        public bool xoa_CTHD(int id)
        {
            return chitiet.xoa(id);
        }
        public DataTable get_ID()
        {
            return chitiet.getid(); 
        }
        public DataTable get_IDMAX()
        {
            return chitiet.get_idmax();
        }
        public int get_Count()
        {
            return chitiet.get_count(); 
        }
    }
}
