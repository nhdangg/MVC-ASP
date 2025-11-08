using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chuong1.Controllers
{
    public class Bai3Controller : Controller
    {
        // GET: Bai3
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult PhuongTrinhBacHai(int soA, int soB, int soC)
        {
            if(soA == 0)
            {
                ViewBag.KetQua = "Hệ số a không được bằng 0 trong phương trình bậc hai.";
                return View("Index");
            }
            if(soB == 0 && soC == 0)
            {
                ViewBag.KetQua = "Phương trình có vô số nghiệm.";
                return View("Index");
            }
            
            ViewBag.SoA = soA;
            ViewBag.SoB = soB;
            ViewBag.SoC = soC;
            double delta = soB * soB - 4 * soA * soC;
            ViewBag.Delta = delta;
            if (delta < 0)
            {
                ViewBag.KetQua = "Phương trình vô nghiệm.";
            }
            else if (delta == 0)
            {
                double x = -soB / (2.0 * soA);
                ViewBag.KetQua = $"Phương trình có nghiệm kép: x1 = x2 = {x}.";
            }
            else
            {
                double x1 = (-soB + Math.Sqrt(delta)) / (2.0 * soA);
                double x2 = (-soB - Math.Sqrt(delta)) / (2.0 * soA);
                ViewBag.KetQua = $"Phương trình có hai nghiệm phân biệt: x1 = {x1}, x2 = {x2}.";
            }
            return View("Index");
        }
    }
}