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
    public class BLL_HangBan
    {
        DAL_HangBan hangban = new DAL_HangBan();    
        public DataTable get_HangBan()
        {
            return hangban.get_hangban();
        }
        public bool them_HangBan(DTO_HangBan hb, int id)
        {
            return hangban.them(hb, id);
        }
    }
}
