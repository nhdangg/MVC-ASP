using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chuong1.Models
{
    public class SanPham
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string LoaiSP { get; set; }
        public long DonGia { get; set; }
        public int SoLuong { get; set; }
        public long ThanhTien { get; set; }
    }
}