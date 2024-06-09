using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CTHDKH
    {
 
        public string ten_pt { get; set; }  
        public int soluong {  get; set; }   
        public int gia { get; set; }   
        
        
        public DTO_CTHDKH(string ten_pt, int soluong, int gia) {            
            this.ten_pt = ten_pt;
            this.soluong = soluong;
            this.gia = gia;
            
        }
    }
}
