using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KetNoi_CSDL.Models;

namespace KetNoi_CSDL.Controllers
{
    public class QL_NhanVienController : Controller
    {
        // GET: QL_NhanVien
        QLNhanVienEntities1 data = new QLNhanVienEntities1();
      
        public ActionResult Index()
        {
            List<NHANVIEN> NV = data.NHANVIENs.ToList();
            return View(NV);
        }

        // GET: QL_NhanVien/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: QL_NhanVien/Create
        public ActionResult Create()
        {
           List<PHONG> PHONG = data.PHONGs.ToList();
           ViewBag.PHONG = new SelectList(PHONG, "Maphong", "Tenphong");

            return View();
        }

        // POST: QL_NhanVien/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                NHANVIEN nv = new NHANVIEN();
                nv.Manv = collection["Manv"];
                nv.Hoten = collection["Hoten"];
                nv.Maphong = collection["Maphong"];
                nv.Luong = Convert.ToDouble(collection["Luong"]);

                data.NHANVIENs.Add(nv);
                data.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: QL_NhanVien/Edit/5
        public ActionResult Edit(string id)
        {
            
            var nv = data.NHANVIENs.FirstOrDefault(x => x.Manv.Trim() == id.Trim());
            if (nv == null)
            {
                return HttpNotFound();
            }

            ViewBag.PHONG = new SelectList(data.PHONGs.ToList(), "Maphong", "Tenphong", nv.Maphong);

            return View(nv);
        }

        // POST: QL_NhanVien/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, FormCollection collection)
        {
            try
            {
                NHANVIEN nv = data.NHANVIENs.FirstOrDefault(x => x.Manv.Trim() == id.Trim());
                nv.Hoten = collection["Hoten"];
                nv.Maphong = collection["Maphong"];
                nv.Luong = Convert.ToDouble(collection["Luong"]);
                data.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: QL_NhanVien/Delete/5
        public ActionResult Delete(string id)
        {
            NHANVIEN nv = data.NHANVIENs.FirstOrDefault(x => x.Manv.Trim() == id.Trim());
            ViewBag.PHONG = new SelectList(data.PHONGs.ToList(), "Maphong", "Tenphong", nv.Maphong);
            return View(nv);
        }

        // POST: QL_NhanVien/Delete/5
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
