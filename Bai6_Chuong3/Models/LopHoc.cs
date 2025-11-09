using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chuong_3.Models
{
    public class LopHoc
    {
        public int MaLop { get; set; }
        public string TenLop { get; set; }

        public LopHoc() { }
        public LopHoc(int maLop, string tenLop)
        {
            MaLop = maLop;
            TenLop = tenLop;
        }
    }
}