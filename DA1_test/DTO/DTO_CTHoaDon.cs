using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CTHoaDon
    {
        public string ten_kh {  get; set; }
        public string ten_xe { get; set; }  
        public string bsx { get; set; } 
        public string dichvu { get; set; }  
        public int slphutung { get; set; }  
        public int tonggia { get; set; }   
        public string tt_thanhtoan { get; set; } 
        public DateTime ngay { get; set; }
        public DTO_CTHoaDon(string ten_kh, string ten_xe, string bsx, string dichvu, int slphutung, int tonggia,  string tt_thanhtoan, DateTime ngay)        
        {
            this.ten_kh = ten_kh;   
            this.ten_xe = ten_xe;
            this.bsx = bsx;
            this.dichvu = dichvu;
            this.slphutung = slphutung;
            this.tonggia = tonggia;
            this.tt_thanhtoan = tt_thanhtoan;   
            this.ngay = ngay;
        }
    }
}
