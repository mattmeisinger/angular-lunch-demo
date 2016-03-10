using AngularTestApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularTestApp.Controllers
{
    public class DocumentsController : Controller
    {
        public static List<Document> Documents { get; set; }

        public DocumentsController()
        {
            if (Documents == null)
            {
                Documents = new List<Document>
                {
                    new Document { Id = 1, Title = "First Test Document", CountryId = 1 },
                    new Document { Id = 2, Title = "Second Test Document", CountryId = 2 },
                    new Document { Id = 3, Title = "Third Test Document", CountryId = 3 },
                };
            }
        }

        public ActionResult Get()
        {
            return Json(Documents);
        }

        public ActionResult Save(Document d)
        {
            // Make this ID one greater than the largest one in the list
            d.Id = Documents.Max(a => a.Id) + 1;

            Documents.Add(d);
            return Json(new { Result = "Success" });
        }
    }
}