using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Help.Ultilities;

namespace Help.AdminSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Session[SessionEnum.UserAdmin.ToString()] == null)
                return RedirectToAction("LogIn", "Account2");

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
