using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Khachhang
    {
        public int id {  get; set; }    
        public string ten {  get; set; } 
        public int tuoi { get; set;}
        public string gioi_tinh {  get; set; } 
        public string diachi { get; set; }
        public string sdt {  get; set; }    
        public DTO_Khachhang(string ten, int tuoi ,string gioi_tinh, string diachi, string sdt) { 
            this.ten = ten; 
            this.tuoi = tuoi;
            this.gioi_tinh = gioi_tinh;
            this.diachi = diachi;   
            this.sdt = sdt;            
        }
    }
}
