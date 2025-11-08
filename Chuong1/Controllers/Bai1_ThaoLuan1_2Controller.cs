using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chuong1.Controllers
{
    public class Bai1_ThaoLuan1_2Controller : Controller
    {
        // GET: Bai1_ThaoLuan1_2
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Bai1_ThaoLuan1_2()
        {
            int SoLuong;
            double DonGia;
            if (!int.TryParse(Request["SoL"], out SoLuong))
            {
                ViewBag.Error = "Số lượng phải là số nguyên!";
                return View("Index");
            }
            if (!double.TryParse(Request["DonG"], out DonGia))
            {
                ViewBag.Error = "Đơn giá phải là số!";
                return View("Index");
            }

            try
            {
                string MaHang = Request["MaH"];
                string TenHang = Request["TenH"];
                SoLuong = int.Parse(Request["SoL"]);
                DonGia = double.Parse(Request["DonG"]);
                double ThanhTien = SoLuong * DonGia;

                ViewBag.MA_HANG = MaHang;
                ViewBag.TEN_HANG = TenHang;
                ViewBag.SO_LUONG = SoLuong;
                ViewBag.DON_GIA = DonGia;
                ViewBag.THANH_TIEN = ThanhTien.ToString("#,0");
                return View("Index");
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Lỗi xử lý dữ liệu: " + ex.Message;
                return View("Index");
            }
        }
    }
}