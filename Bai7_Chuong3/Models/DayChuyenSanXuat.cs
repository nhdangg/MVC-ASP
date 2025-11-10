using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai7_Chuong3.Models
{
    public class DayChuyenSanXuat
    {
        public string MaDayChuyen { get; set; }
        public string TenDayChuyen { get; set; }

        public DayChuyenSanXuat() { }

        public DayChuyenSanXuat(string ma, string ten)
        {
            MaDayChuyen = ma;
            TenDayChuyen = ten;
        }
    }
}