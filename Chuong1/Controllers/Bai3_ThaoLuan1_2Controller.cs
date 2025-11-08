using Chuong1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chuong1.Controllers
{
    public class Bai3_ThaoLuan1_2Controller : Controller
    {
        // GET: Bai3_ThaoLuan1_2
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(SanPham sp)
        {
            // Tính thành tiền
            sp.ThanhTien = sp.DonGia * sp.SoLuong;

            return View("Index", sp);
        }
    }
}