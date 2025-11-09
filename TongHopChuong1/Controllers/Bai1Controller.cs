using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chuong1.Controllers
{
    public class Bai1Controller : Controller
    {
        // GET: Bai1
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Tinh(int soA, int soB, string phepTinh)
        {
            ViewBag.SoA = soA;
            ViewBag.SoB = soB;
            ViewBag.PhepTinh = phepTinh;
            switch (phepTinh)
            {
                case "cong":
                    ViewBag.KetQuaa = soA + soB;
                    return View();
                    break;
                case "tru":
                    ViewBag.KetQuaa = soA - soB;
                    return View();
                    break;
                case "nhan":
                    ViewBag.KetQuaa = soA * soB;
                    return View();
                    break;
                case "chia":
                    if (soB != 0)
                    {
                        ViewBag.KetQuaa = (double)soA / soB;
                        return View();
                    }
                    else
                    {
                        ViewBag.KetQuaa = "Lỗi: Không thể chia cho 0.";
                        return View();
                    }
                    break;
                default:
                    ViewBag.KetQuaa = "Phép tính không hợp lệ.";
                    return View();
                    break;
            }
        }
    }
}