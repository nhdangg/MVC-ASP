using Chuong1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chuong1.Controllers
{
    public class TL_GiaiPT_Bac1Controller : Controller
    {
        // GET: TL_GiaiPT_Bac1
        public ActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Index(TL_GaiPT_B1 pt)
        {  
            return View(pt);
        }
    }
}