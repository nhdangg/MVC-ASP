using Bai7_Chuong3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai7_Chuong3.Controllers
{
    public class QuanLyNhanVienController : Controller
    {
        // GET: QuanLyNhanVien_
        public static List<NhanVien> dsNV = new List<NhanVien>()
        {
            new NhanVien("NV01", "Nguyen Van Anh", "Phú Thọ", 15, 200000,"DC01"),
            new NhanVien("NV02", "Lê Thu Hà", "Hải Phòng", 27, 250000, "DC02"),
            new NhanVien("NV03", "Nguyễn Văn Hoàng", "Hà Nội", 18, 250000, "DC04"),
            new NhanVien("NV04", "Trần Thu Hương", "Hải Phòng", 25, 190000, "DC01"),
            new NhanVien("NV05", "Ngô Phương Thảo", "Quảng Ninh", 20, 180000, "DC03")
        };
        public static List<DayChuyenSanXuat> dsDC = new List<DayChuyenSanXuat>()
        {
            new DayChuyenSanXuat("DC01", "Dây chuyền lắp ráp"),
            new DayChuyenSanXuat("DC02", "Dây chuyền kiểm tra chất lượng"),
            new DayChuyenSanXuat("DC03", "Dây chuyền đóng gói"),
            new DayChuyenSanXuat("DC04", "Dây chuyền kho vận và lưu trữ"),
            new DayChuyenSanXuat("DC05", "Dây chuyền bảo trì và bảo dưỡng")
        };
        public ActionResult Index()
        {
            return View(dsNV);
        }
        public PartialViewResult DayChuyenPartial()
        {
            return PartialView(dsDC);
        }
        public ActionResult DanhSachNhanVienTheoDayChuyen(string maDC)
        {
            var nvTheoDC = dsNV.Where(nv => nv.MaDayChuyen == maDC).ToList();
            return View(nvTheoDC);
        }

        // GET: QuanLyNhanVien_/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: QuanLyNhanVien_/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QuanLyNhanVien_/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: QuanLyNhanVien_/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: QuanLyNhanVien_/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: QuanLyNhanVien_/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: QuanLyNhanVien_/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
