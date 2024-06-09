using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Xe
    {
        public int id { get; set; }
        public string ten_xe { get; set; }    
        public string bienso { get; set; }  
        public string tinh_trang { get; set; }  
        public int bhx {  get; set; }    
        public string chu_so_huu { get; set; }  
        public DTO_Xe( string ten_xe, string bienso, string tinh_trang, int bhx, string chu_so_huu) { 
            
            this.ten_xe =  ten_xe;
            this.bienso = bienso;
            this .tinh_trang = tinh_trang;  
            this .bhx = bhx;    
            this.chu_so_huu = chu_so_huu;
        } 
    }
}
