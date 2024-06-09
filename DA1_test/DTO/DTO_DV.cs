using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DV
    {
        public string ten_dv {  get; set; } 
        public int gia { get; set; }    
        public DTO_DV(string ten_dv, int gia) { 
            this.ten_dv = ten_dv;
            this.gia = gia; 
        }
    }
}
