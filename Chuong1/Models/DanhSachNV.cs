using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chuong1.Models
{
    public class DanhSachNV
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string DonVi { get; set; }
        public string GioiTinh { get; set; }
        public long SoNgayCong { get; set; }
        public long ThuNhap { get; set; }
        public DanhSachNV()
        {
        }
        public DanhSachNV(string maNV, string tenNV, string donVi, string gioiTinh, long soNgayCong, long thuNhap)
        {
            MaNV = maNV;
            TenNV = tenNV;
            DonVi = donVi;
            GioiTinh = gioiTinh;
            SoNgayCong = soNgayCong;
            ThuNhap = thuNhap;
        }
        public long TinhThuNhap
        {
            get
            {
                return SoNgayCong * ThuNhap;
            }
        }
    }
}