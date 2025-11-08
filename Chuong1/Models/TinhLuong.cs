using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chuong1.Models
{
    public class TinhLuong
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public double LuongCoBan { get; set; }
        public double HeSoLuong { get; set; }

        public TinhLuong()
        {
          
        }
        public TinhLuong(string maNV, string tenNV, double luongCoBan, double heSoLuong)
        {
            MaNV = maNV;
            TenNV = tenNV;
            LuongCoBan = luongCoBan;
            HeSoLuong = heSoLuong;
        }
        public double TinhLuongThucLinh
        {
            get
            {
                return LuongCoBan * HeSoLuong;
            }
        }
    }
}