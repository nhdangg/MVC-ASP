using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Chuong1.Models
{
    public class MayTinh
    {
        public string MaMay { get; set; }
        public string TenDongMay { get; set; }
        public decimal GiaBan { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime NgaySanXuat { get; set; }
        public string HangSanXuat { get; set; }

        public MayTinh()
        {
        }
        public MayTinh(string maMay, string tenDongMay, decimal giaBan, DateTime ngaySanXuat, string hangSanXuat)
        {
            MaMay = maMay;
            TenDongMay = tenDongMay;
            GiaBan = giaBan;
            NgaySanXuat = ngaySanXuat;
            HangSanXuat = hangSanXuat;
        }
    }
}