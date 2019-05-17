using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using LibraryCatalogue.Client.Models;

namespace LibraryCatalogue.Client.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Query query = new Query();
            return View(query);
        }
    }
}
