using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using LibraryCatalogue.Client.Models;

namespace LibraryCatalogue.Client.Controllers
{
    public class HomeController : BaseController
    {
        
        public ActionResult Index()
        {
            Query query = new Query();
            return View(query);
        }

        [HttpPost]
        public ActionResult Index(Query model)
        {
            if (model.item == "Magazine")
            {
                return Content("Coming soon..");
            }
           return searchItem(model);
        }
    }
}
