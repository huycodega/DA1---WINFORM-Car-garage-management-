using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_PhieuLL
    {
        public string ten_kh { get; set; }
        public int tuoi { get; set; }   
        public string ten_xe { get; set; }
        public string bienso { get; set; }
        public string diachi { get; set; }  
        public string sdt {  get; set; }    
        public string nguoi_lam_viec { get; set; }
        public DateTime ngay_hen { get; set; }
        public string dichvu { get; set; }
        public string tt_thanhtoan { get; set; }    
        public DTO_PhieuLL(string ten_kh, int tuoi, string diacchi, string sdt, string ten_xe, string bienso, string nguoi_lam_viec, string dichvu, DateTime ngay_hen, string tt_thanhtoan)
        {
            this.ten_kh = ten_kh;
            this.tuoi = tuoi;
            this.diachi = diacchi;
            this.sdt = sdt; 
            this.ten_xe = ten_xe;
            this.bienso = bienso;
            this.nguoi_lam_viec = nguoi_lam_viec;
            this.dichvu = dichvu;
            this.ngay_hen = ngay_hen;
            this.tt_thanhtoan = tt_thanhtoan;
        }
    }
}
