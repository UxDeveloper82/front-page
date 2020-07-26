using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UxApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Portfolio()
        {
            ViewBag.Title = "Portfolio Page";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Title = "Contact Page";

            return View();
        }

        public ActionResult Blog()
        {
            ViewBag.Title = "Blog Page";

            return View();
        }
    }
}
