using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularTestApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult Countries()
        {
            var countriesDictionary = new Dictionary<string, string>
            {
                { "1", "US" },
                { "2", "UK" },
                { "3", "Germany" },
                { "4", "Australia" },
                { "5", "Switzerland" },
            };
            return Json(countriesDictionary);
        }
    }
}