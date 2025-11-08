using Chuong_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chuong_3.Controllers
{
    public class Sinh_VienController : Controller
    {
        public static List<LopHoc> LH = new List<LopHoc>()
        {
            new LopHoc(1,"Cong Nghe Thong Tin"),
            new LopHoc(2,"An Toan Thong Tin"),
            new LopHoc(3,"He Thong Thong Tin"),
            new LopHoc(4,"Khoa Hoc May Tinh")
        };
        public static List<SinhVien> SV = new List<SinhVien>()
        {
            new SinhVien(1,"Nguyen Van A",20,"Nam",1),
            new SinhVien(2,"Tran Thi B",21,"Nu",2),
            new SinhVien(3,"Le Van C",22,"Nam",1),
            new SinhVien(4,"Pham Thi D",20,"Nu",2),
            new SinhVien(5,"Hoang Van E",23,"Nam",1)
        };
        // GET: Sinh_Vien
        public ActionResult Index()
        {
            return View(SV);
        }
        public ActionResult XapSepTang()
        {
            var svTang = SV.OrderBy(sv => sv.Tuoi).ToList();
            return View("Index", svTang);
        }
        public ActionResult XapSepGiam()
        {
            var svGiam = SV.OrderByDescending(sv => sv.Tuoi).ToList();
            return View("Index", svGiam);
        }
        public PartialViewResult LopHoc()
        {
            return PartialView(LH);
        }
        public ActionResult DanhSachSinhVien(int lopId)
        {
            var svTheoLop = SV.Where(sv => sv.MaLop == lopId).ToList();
            ViewBag.Lop = LH.FirstOrDefault(l => l.MaLop == lopId)?.TenLop;
            return View(svTheoLop);
        }
        // GET: Sinh_Vien/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Sinh_Vien/Create
        public ActionResult Create()
        {
           // Tạo SelectList: giá trị là MaLop, hiển thị là TenLop
            ViewBag.Lop = new SelectList(LH, "MaLop", "TenLop");
            return View();
        }

        // POST: Sinh_Vien/Create
        [HttpPost]
        public ActionResult Create(SinhVien sv)
        {
            try
            {
                // TODO: Add insert logic here

                if (ModelState.IsValid)
                {
                    SV.Add(sv); // Lưu dữ liệu
                    return RedirectToAction("Index"); // ✅ Đúng
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Sinh_Vien/Edit/5
        public ActionResult Edit(int id)
        {
            var sv =SV.FirstOrDefault(x => x.MaSV == id);

            if (sv == null)
            {
                return HttpNotFound();
            }

            // Đổ danh sách lớp vào ViewBag
            ViewBag.Lop = new SelectList(LH, "MaLop", "TenLop", sv.MaLop);

            return View(sv); // Truyền model sang View
        }

        // POST: Sinh_Vien/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, SinhVien sv)
        {
            try
            {
                // TODO: Add update logic here
                for(int i=0; i<SV.Count; i++)
                {
                    if(SV[i].MaSV == id)
                    {
                        SV[i].MaLop = id;
                        SV[i].HoTen = sv.HoTen;
                        SV[i].Tuoi = sv.Tuoi;
                        SV[i].GioiTinh = sv.GioiTinh;
                        SV[i].MaLop = sv.MaLop;

                        break;
                    }
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Sinh_Vien/Delete/5
        public ActionResult Delete(int id)
        {
            SinhVien sv = null;
            for (int i = 0; i < SV.Count; i++)
            {
                if (SV[i].MaSV == id)
                {
                   sv = SV[i];
                    break;
                }
            }
            ViewBag.Lop = new SelectList(LH, "MaLop", "TenLop", sv.MaLop);
            return View(sv);
        }

        // POST: Sinh_Vien/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, SinhVien sv)
        {
            try
            {
                for (int i = 0; i < SV.Count; i++)
                {
                    if (SV[i].MaSV == id)
                    {
                        SV.RemoveAt(i);
                        break;
                    }
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
