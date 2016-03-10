using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularTestApp.Models
{
    public class Document
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int CountryId { get; set; }
    }
}