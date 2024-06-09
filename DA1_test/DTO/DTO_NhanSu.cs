using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhanSu 
    {  

        public byte[] hinhanh { get; set; }   
        public string ten_ns { get; set; }  
        public string gioitinh { get; set; }    
        public DateTime ngay_sinh { get; set; } 
        public string dc_ns { get; set; }
        public string sdt {  get; set; }    
        public  string chuc_vu { get; set; }
        public DTO_NhanSu (byte[] hinhanh, string ten_ns, string gioitinh, DateTime ngay_sinh, string dc_ns, string sdt, string chucvu)
        {
            this.hinhanh = hinhanh; 
            this.ten_ns = ten_ns;
            this.gioitinh = gioitinh;
            this.ngay_sinh  = ngay_sinh;    
            this.dc_ns = dc_ns; 
            this.sdt = sdt; 
            this.chuc_vu = chucvu;
             
        }
    }
}
