using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HDNhap
    {
        public byte[] hinhanh { get; set; }
        public string ten_pt { get; set; }
        public int soluong { get; set; }
        public int gia { get; set; }
        public DateTime ngaynhap { get; set; }
        public string noi_cung_cap { get; set; }
        public string tinhtrang { get; set; }
        public DTO_HDNhap(byte[] hinhanh, string ten_pt, int soluong, int gia, DateTime ngaynhap, string noi_cung_cap, string tinhtrang)
        {
            this.hinhanh = hinhanh;
            this.ten_pt = ten_pt;
            this.soluong = soluong;
            this.gia = gia;
            this.ngaynhap = ngaynhap;
            this.noi_cung_cap = noi_cung_cap;
            this.tinhtrang = tinhtrang;
        }
    }
}
