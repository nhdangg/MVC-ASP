using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chuong1.Controllers
{
    public class Bai2Controller : Controller
    {
        // GET: Bai2
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Tinh_Tien_Dien(long cu, long moi, string loai, string check)
        {
            if (moi < cu || cu < 0 || moi < 0)
            {
                ViewBag.ThongBao = "Chỉ số điện không hợp lệ!";
                return View("Index");
            }

            double tien = 0;
            long sodien = moi - cu;
            ViewBag.SoDien = sodien;
            if (loai == "SinhHoat")
            {
                if (check == "true")
                {
                    if (sodien <= 100)
                    {
                        tien = (sodien * 2000) * 0.9;
                        ViewBag.Tien = tien;
                        return View();
                    }
                    else if (sodien > 100 && sodien <= 150)
                    {
                        sodien -= 100;
                        tien = (100 * 2000 + sodien * 2500) * 0.9;
                        ViewBag.Tien = tien;
                        return View();
                    }
                    else if (sodien > 150 && sodien <= 200)
                    {
                        sodien -= 150;
                        tien = (100 * 2000 + 50 * 2500 + sodien * 3000) * 0.9;
                        ViewBag.Tien = tien;
                        return View();
                    }
                    else
                    {
                        sodien -= 200;
                        tien = (100 * 2000 + 50 * 2500 + 50 * 3000 + sodien * 4000) * 0.9;
                        ViewBag.Tien = tien;
                        return View();
                    }
                }
                else
                {
                    if (sodien <= 100)
                    {
                        tien = sodien * 2000;
                        ViewBag.Tien = tien;
                        return View();
                    }
                    else if (sodien > 100 && sodien <= 150)
                    {
                        sodien -= 100;
                        tien = 100 * 2000 + sodien * 2500;
                        ViewBag.Tien = tien;
                        return View();
                    }
                    else if (sodien > 150 && sodien <= 200)
                    {
                        sodien -= 150;
                        tien = 100 * 2000 + 50 * 2500 + sodien * 3000;
                        ViewBag.Tien = tien;
                        return View();
                    }
                    else
                    {
                        sodien -= 200;
                        tien = 100 * 2000 + 50 * 2500 + 50 * 3000 + sodien * 4000;
                        ViewBag.Tien = tien;
                        return View();
                    }
                }
            }
            // nếu loai là kinh doanh thì tiền điện sẽ tăng 20%
            else if (loai == "KinhDoanh")
            {
                if( check == "true")
                {
                    if (sodien <= 100)
                    {
                        tien = (sodien * 2000 * 1.2) * 0.9;
                        ViewBag.Tien = tien;
                        return View();
                    }
                    else if (sodien > 100 && sodien <= 150)
                    {
                        sodien -= 100;
                        tien =  ((100 * 2000 + sodien * 2500) * 1.2) * 0.9;
                        ViewBag.Tien = tien;
                        return View();
                    }
                    else if (sodien > 150 && sodien <= 200)
                    {
                        sodien -= 150;
                        tien = ((100 * 2000 + 50 * 2500 + sodien * 3000) * 1.2) * 0.9;
                        ViewBag.Tien = tien;
                        return View();
                    }
                    else
                    {
                        sodien -= 200;
                        tien = ((100 * 2000 + 50 * 2500 + 50 * 3000 + sodien * 4000) * 1.2) * 0.9;
                        ViewBag.Tien = tien;
                        return View();
                    }
                }
                else
                {
                    if (sodien <= 100)
                    {
                        tien = (sodien * 2000 * 1.2);
                        ViewBag.Tien = tien;
                        return View();
                    }
                    else if (sodien > 100 && sodien <= 150)
                    {
                        sodien -= 100;
                        tien = (long)((100 * 2000 + sodien * 2500) * 1.2);
                        ViewBag.Tien = tien;
                        return View();
                    }
                    else if (sodien > 150 && sodien <= 200)
                    {
                        sodien -= 150;
                        tien = (long)((100 * 2000 + 50 * 2500 + sodien * 3000) * 1.2);
                        ViewBag.Tien = tien;
                        return View();
                    }
                    else
                    {
                        sodien -= 200;
                        tien = (long)((100 * 2000 + 50 * 2500 + 50 * 3000 + sodien * 4000) * 1.2);
                        ViewBag.Tien = tien;
                        return View();
                    }
                }
            }
            // nếu loai là Sản xuất thì tiền điện sẽ tăng 30%   
            else if (loai == "SanXuat")
            {
                if (check == "true")
                {
                    if (sodien <= 100)
                    {
                        tien = (sodien * 2000 * 1.3) * 0.9;
                        ViewBag.Tien = tien;
                        return View();
                    }
                    else if (sodien > 100 && sodien <= 150)
                    {
                        sodien -= 100;
                        tien = ((100 * 2000 + sodien * 2500) * 1.3) * 0.9;
                        ViewBag.Tien = tien;
                        return View();
                    }
                    else if (sodien > 150 && sodien <= 200)
                    {
                        sodien -= 150;
                        tien = ((100 * 2000 + 50 * 2500 + sodien * 3000) * 1.3) * 0.9;
                        ViewBag.Tien = tien;
                        return View();
                    }
                    else
                    {
                        sodien -= 200;
                        tien = ((100 * 2000 + 50 * 2500 + 50 * 3000 + sodien * 4000) * 1.3) * 0.9;
                        ViewBag.Tien = tien;
                        return View();
                    }
                }
                else
                {
                    if (sodien <= 100)
                    {
                        tien = (sodien * 2000 * 1.3);
                        ViewBag.Tien = tien;
                        return View();
                    }
                    else if (sodien > 100 && sodien <= 150)
                    {
                        sodien -= 100;
                        tien = ((100 * 2000 + sodien * 2500) * 1.3);
                        ViewBag.Tien = tien;
                        return View();
                    }
                    else if (sodien > 150 && sodien <= 200)
                    {
                        sodien -= 150;
                        tien = ((100 * 2000 + 50 * 2500 + sodien * 3000) * 1.3);
                        ViewBag.Tien = tien;
                        return View();
                    }
                    else
                    {
                        sodien -= 200;
                        tien = ((100 * 2000 + 50 * 2500 + 50 * 3000 + sodien * 4000) * 1.3);
                        ViewBag.Tien = tien;
                        return View();
                    }
                }
            }
            else
            {
                ViewBag.ThongBao = "Loại khách hàng không hợp lệ!";
                return View("Index");
            }
        }
    }
}