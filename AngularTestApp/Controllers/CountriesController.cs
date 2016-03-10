using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularTestApp.Controllers
{
    public class CountriesController : Controller
    {
        public ActionResult Get()
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