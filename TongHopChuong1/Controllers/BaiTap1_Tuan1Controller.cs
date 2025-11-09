using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chuong1.Controllers
{
    public class BaiTap1_Tuan1Controller : Controller
    {
        // GET: BaiTap1_Tuan1
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ThanhTien(long gia, long soluong, string mah, string ten, string loai)
        {
            ViewBag.maHang = mah;
            ViewBag.Gia = gia;
            ViewBag.TenHang = ten;
            ViewBag.LoaiHang = loai;
            ViewBag.SoLuong = soluong;
            ViewBag.ThanhTien = (gia * soluong).ToString("#,0") + " VNĐ";
            return View("Index");
        }
    }
}