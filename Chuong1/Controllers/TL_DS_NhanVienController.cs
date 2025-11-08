using Chuong1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chuong1.Controllers
{
    public class TL_DS_NhanVienController : Controller
    {
        // GET: TL_DS_NhanVien
       

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult HienThi()
        {
            String maNV = Request.Form["txtMaNV"];
            String tenNV = Request.Form["txtTenNV"];
            String donVi = Request.Form["txtDonVi"];
            String gioiTinh = Request.Form["txtGioiTinh"];
            long soNgayCong = Convert.ToInt64(Request.Form["txtSoNgayCong"]);
            long thuNhap = Convert.ToInt64(Request.Form["txtThuNhap"]);

            Models.DanhSachNV emp = new Models.DanhSachNV(maNV, tenNV, donVi, gioiTinh, soNgayCong, thuNhap);
            return View("HienThi", emp);
        }
    }
}