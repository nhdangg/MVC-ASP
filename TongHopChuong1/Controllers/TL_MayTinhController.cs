using Chuong1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chuong1.Controllers
{
    public class TL_MayTinhController : Controller
    {
        static List<MayTinh> mayTinhs = new List<MayTinh>()
        {
            new MayTinh("1234567890", "Dell XPS 13", 1200.00m, new DateTime(2022, 5, 1), "Dell"),
            new MayTinh("248274586", "MacBook Pro", 1500.00m, new DateTime(2022, 6, 15), "Apple"),
            new MayTinh("837582757", "HP Spectre x360", 1300.00m, new DateTime(2022, 7, 10), "HP"),
            new MayTinh("583959485", "Lenovo ThinkPad X1", 1400.00m, new DateTime(2022, 8, 5), "Lenovo"),
            new MayTinh("884747474", "Asus ZenBook 14", 1100.00m, new DateTime(2022, 9, 20), "Asus")
        };
        // GET: TL_MayTinh
        public ActionResult Index()
        {
            return View(mayTinhs);
        }
        public ActionResult DanhSachMayTinh()
        {
            var top3 = mayTinhs.OrderBy(x => x.GiaBan).Take(3).ToList();
            return View("Index", top3);
        }
        public ActionResult SapXepGiam()
        {
            var ketQua = mayTinhs.OrderByDescending(x => x.GiaBan).ToList();
            return View("Index", ketQua);
        }
        public ActionResult TimKiemHang(string hang)
        {
            var ketQua = mayTinhs.Where(x => x.HangSanXuat.Equals(hang, StringComparison.OrdinalIgnoreCase)).ToList();
            return View("Index", ketQua);
        }
        // GET: TL_MayTinh/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TL_MayTinh/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TL_MayTinh/Create
        [HttpPost]
        public ActionResult Create(MayTinh mt)
        {
            try
            {
               if(ModelState.IsValid)
                {
                    mayTinhs.Add(mt);
                    return RedirectToAction("Index");
                }
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: TL_MayTinh/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TL_MayTinh/Edit/5
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

        // GET: TL_MayTinh/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TL_MayTinh/Delete/5
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
