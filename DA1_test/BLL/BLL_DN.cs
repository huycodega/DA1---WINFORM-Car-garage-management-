using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLL_DN
    {
        DAL_DN dn = new DAL_DN();
        public DataTable get_DN(string tk) { 
            return dn.get_dn(tk);
        }
    }
}
