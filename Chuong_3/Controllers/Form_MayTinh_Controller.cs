using Chuong_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chuong_3.Controllers
{
    public class Form_MayTinh_Controller : Controller
    {
       List<MayTinh> lstMayTinh = new List<MayTinh>()
        {
            new MayTinh { MaMay = "MT01", TenDongMay = "Dell XPS 13", GiaBan = 30000000, NgaySanXuat = new DateTime(2022, 5, 1), HangSanXuat = "Dell" },
            new MayTinh { MaMay = "MT02", TenDongMay = "MacBook Air", GiaBan = 35000000, NgaySanXuat = new DateTime(2021, 11, 15), HangSanXuat = "Apple" },
            new MayTinh { MaMay = "MT03", TenDongMay = "HP Spectre x360", GiaBan = 28000000, NgaySanXuat = new DateTime(2022, 3, 10), HangSanXuat = "HP" }
        };
        // GET: Form_MayTinh_
        public ActionResult Index()
        {
            return View(lstMayTinh);
        }
        public ActionResult GiaThap()
        {
            var dsGiaThap = lstMayTinh.OrderBy(m => m.GiaBan).Take(2).ToList();
            return View("Index", dsGiaThap);
        }
        // GET: Form_MayTinh_/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Form_MayTinh_/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Form_MayTinh_/Create
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

        // GET: Form_MayTinh_/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Form_MayTinh_/Edit/5
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

        // GET: Form_MayTinh_/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Form_MayTinh_/Delete/5
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
