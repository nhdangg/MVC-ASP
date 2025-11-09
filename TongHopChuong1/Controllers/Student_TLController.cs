using Chuong1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chuong1.Controllers
{
    public class Student_TLController : Controller
    {
        // GET: Student_TL
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Student st)
        {
            return View(st);
        }
    }
}