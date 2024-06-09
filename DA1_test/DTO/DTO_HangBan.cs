using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HangBan
    {
        public string ten_pt {  get; set; } 
        public int so_luong { get; set; }   
        public int gia { get; set; }    
        public DateTime ngay { get; set; }
        public DTO_HangBan(string ten_pt, int so_luong, int gia, DateTime ngay)
        {
            this.ten_pt = ten_pt;   
            this.so_luong = so_luong;   
            this.gia = gia; 
            this.ngay = ngay;   
        }
    }
}
