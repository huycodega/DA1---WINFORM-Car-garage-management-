using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_BangCong
    {
        public int thang {  get; set; } 
        public int nam { get; set; }    
        public DateTime ngaytinhcong { get; set; }  
        public float ngaycongtrongthang { get; set; }
        public DTO_BangCong(int thang, int nam, DateTime ngaytinhcong, float ngaycongtrongthang)
        {
            this.thang = thang;
            this.nam = nam;
            this.ngaytinhcong = ngaytinhcong;
            this.ngaycongtrongthang = ngaycongtrongthang;
        }   
    }
}
