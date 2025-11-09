using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chuong_3.Models
{
    public class SinhVien
    {
        public int MaSV { get; set; }
        public string HoTen { get; set; }
        public int Tuoi { get; set; }
        public string GioiTinh { get; set; }
        public int MaLop { get; set; }
        public SinhVien() { }
        public SinhVien(int maSV, string hoTen, int tuoi, string gioiTinh, int maLop)
        {
            MaSV = maSV;
            HoTen = hoTen;
            Tuoi = tuoi;
            GioiTinh = gioiTinh;
            MaLop = maLop;
        }
    }
}