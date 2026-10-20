using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BE1.Areas.Admin.Controllers
{
    public class homeController : Controller
    {
        // GET: Admin/home
        public ActionResult test()
        {
            return View();
        }
    }
}