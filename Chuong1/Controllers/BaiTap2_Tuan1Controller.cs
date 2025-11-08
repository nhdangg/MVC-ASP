using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chuong1.Controllers
{
    public class BaiTap2_Tuan1Controller : Controller
    {
        // GET: BaiTap2_Tuan1
        public ActionResult Nhap()
        {
            return View();
        }
        // -------------------------------
        // CÁCH 1: Lấy dữ liệu bằng Request
        // -------------------------------
        public ActionResult ThanhTien()
        {
            string MaHang = Request["mah"];
            long Gia = long.Parse(Request["gia"]);
            string TenHang = Request["ten"];
            string LoaiHang = Request["loai"];
            int SoLuong = int.Parse(Request["soluong"]);
            long Tien = Gia * SoLuong;
          

            ViewBag.maHang = MaHang;
            ViewBag.Gia = Gia;
            ViewBag.TenHang = TenHang;
            ViewBag.LoaiHang = LoaiHang;
            ViewBag.SoLuong = SoLuong;
            ViewBag.ThanhTien = Tien.ToString("#,0") + " VNĐ";
            return View("Nhap");
        }


        // -------------------------------
        // CÁCH 2: Lấy dữ liệu bằng FormCollection
        // -------------------------------
        //[HttpPost]
        //public ActionResult ThanhTien(FormCollection f)
        //{
        //    string MaHang = f["mah"];
        //    long Gia = long.Parse(f["gia"]);
        //    string TenHang = f["ten"];
        //    string LoaiHang = f["loai"];
        //    int SoLuong = int.Parse(f["soluong"]);
        //    long Tien = Gia * SoLuong;

        //    ViewBag.maHang = MaHang;
        //    ViewBag.Gia = Gia.ToString("#,##0");
        //    ViewBag.TenHang = TenHang;
        //    ViewBag.LoaiHang = LoaiHang;
        //    ViewBag.SoLuong = SoLuong;
        //    ViewBag.ThanhTien = Tien.ToString("#,##0") + " VNĐ";

        //    return View("Nhap");
        //}
    }
}