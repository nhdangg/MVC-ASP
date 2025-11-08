using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chuong1.Controllers
{
    public class Bai2_ThaoLuan1_2Controller : Controller
    {
        // GET: Bai2_ThaoLuan1_2
     
        public ActionResult NhapLuong(FormCollection form)
        {
            double heSoLuong;
            long luongCoBan;
            // Nếu là GET → chỉ hiển thị form
            if (Request.HttpMethod == "GET")
            {
                return View();
            }
            if(!double.TryParse(form["HeSoLuong"], out heSoLuong))
            {
                ViewBag.Error = "Hệ số lương phải là số hợp lệ.";
                return View();
            }
            if (!long.TryParse(form["LuongCoBan"], out luongCoBan))
            {
                ViewBag.Error = "Lương cơ bản phải là số hợp lệ.";
                return View();
            }
            // Nếu là POST → nhận dữ liệu từ FormCollection
            string maNV = form["MaNV"];
            string hoTen = form["HoTen"];
            heSoLuong = double.Parse(form["HeSoLuong"]);
            luongCoBan = long.Parse(form["LuongCoBan"]);

            double luong = heSoLuong * luongCoBan;

            // Truyền kết quả sang View
            ViewBag.MaNV = maNV;
            ViewBag.HoTen = hoTen;
            ViewBag.HeSoLuong = heSoLuong;
            ViewBag.LuongCoBan = luongCoBan;
            ViewBag.Luong = luong.ToString("#,0") + " VNĐ";

            return View();
        }
    }
}