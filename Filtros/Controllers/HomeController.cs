using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filtros.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            int zero = 0;
            int result = 1000 / zero;

            ViewBag.Message = "Result: " + result;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [OutputCache(Duration = 10)]
        public ActionResult Time()
        {
            return Content(DateTime.Now.ToLongTimeString());
        }

    }
}