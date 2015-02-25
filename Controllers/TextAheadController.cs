using GridSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GridSample.Controllers
{
    public class TextAheadController : Controller
    {
        // GET: TextAhead
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Search()
        {
            return View();
        }

        
        [HttpPost, ActionName("Search")]
        public ActionResult SearchPost()
        {
        
            var countries = new List<SearchTypeAheadEntity>
            {
                new SearchTypeAheadEntity {ShortCode = "US", Name = "United States"},
                new SearchTypeAheadEntity {ShortCode = "CA", Name = "Canada"},
                new SearchTypeAheadEntity {ShortCode = "AF", Name = "Afghanistan"},
                new SearchTypeAheadEntity {ShortCode = "AL", Name = "Albania"},
                new SearchTypeAheadEntity {ShortCode = "DZ", Name = "Algeria"},
                new SearchTypeAheadEntity {ShortCode = "DS", Name = "American Samoa"},
                new SearchTypeAheadEntity {ShortCode = "AD", Name = "Andorra"},
                new SearchTypeAheadEntity {ShortCode = "AO", Name = "Angola"},
                new SearchTypeAheadEntity {ShortCode = "AI", Name = "Anguilla"},
                new SearchTypeAheadEntity {ShortCode = "AQ", Name = "Antarctica"},
                new SearchTypeAheadEntity {ShortCode = "AG", Name = "Antigua and/or Barbuda"}
            };

            return Json(countries, JsonRequestBehavior.AllowGet);

        }

        public ActionResult TypeAhead()
        {
            return View();
        }
    }
}