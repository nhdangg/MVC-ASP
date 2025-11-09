using Chuong1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chuong1.Controllers
{
    public class TinhLuongNVController : Controller
    {
        // GET: TinhLuongNV
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult HienThi()
        {
            string id = Request.Form["txtMaNV"];
            string name = Request.Form["txtTenNV"];
            double basicSalary = Convert.ToDouble(Request.Form["txtLuongCB"]);
            double salaryCoefficient = Convert.ToDouble(Request.Form["txtHeSoLuong"]);

            TinhLuong emp = new TinhLuong(id, name, basicSalary, salaryCoefficient);
            return View("HienThi",emp);
        }

    }
}