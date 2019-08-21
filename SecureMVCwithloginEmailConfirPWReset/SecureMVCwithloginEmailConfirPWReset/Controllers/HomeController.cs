using SecureMVCwithloginEmailConfirPWReset.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SecureMVCwithloginEmailConfirPWReset.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ABC_Company_DBEntities _context = new ABC_Company_DBEntities();
            var allitem = _context.Mobiles.ToList();
            return View(allitem);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}