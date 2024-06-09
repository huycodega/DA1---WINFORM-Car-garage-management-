using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CTBangCong
    {
        public int id_bangcong {  get; set; }
        public int nhanvien { get; set; }   
        public string hoten { get; set; }   
        public float ngaycong { get; set; }
        public float ngayphep { get; set; }
        public int tongngaycong { get; set; }
        public DTO_CTBangCong(int id_bangcong, int nhanvien, string hoten, float ngaycong, float ngayphep, int tongngaycong)
        {
            this.id_bangcong = id_bangcong;
            this.nhanvien = nhanvien;
            this.hoten = hoten;
            this.ngaycong = ngaycong;
            this.ngayphep = ngayphep;
            this.tongngaycong = tongngaycong;
        }
    }
}
