using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai7_Chuong3.Models
{
    public class NhanVien
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string DiaChi { get; set; }
        public int SoNgayLam { get; set; }
        public int LuongTheoNgay { get; set; }
        public string MaDayChuyen { get; set; }
        public NhanVien() { }
        public NhanVien(string maNV, string tenNV, string diaChi, int soNgayLam, int luongTheoNgay, string madaychuyen)
        {
            this.MaNV = maNV;
            this.TenNV = tenNV;
            this.DiaChi = diaChi;
            this.SoNgayLam = soNgayLam;
            this.LuongTheoNgay = luongTheoNgay;
            this.MaDayChuyen = madaychuyen;
        }
        
        public int TinhLuong()
        {
            return SoNgayLam * LuongTheoNgay;
        }
    }
}