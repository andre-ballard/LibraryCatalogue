using LibraryCatalogue.Client.Interfaces;
using LibraryCatalogue.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryCatalogue.Client.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base
        protected Library catalogue = new Library();

        public ActionResult searchItem(Query model)
        {
            var library = new Library();
            var librarymodel = new Library();
            int search;
            if (model.item == "Movie")
            {
                var item = new Movie();
                
                switch (model.parameter)
                {
                    case "Title":
                        item.Title = model.query;
                        search = 0;
                        librarymodel.Movies = librarymodel.GetItems(item, search);
                        break;
                    case "Subject":
                        item.Subject = model.query;
                        search = 1;
                        librarymodel.Movies = librarymodel.GetItems(item, search);
                        break;
                    case "Author":
                        item.Director = model.query;
                        search = 2;
                        librarymodel.Movies = librarymodel.GetItems(item, search);
                        break;

                }
                return View("Movies", librarymodel);
            }
            else if(model.item == "Book")
            {
                var item = new Book();
                switch (model.parameter)
                {
                    case "Title":
                        item.Title = model.query;
                        search = 0;
                        librarymodel.Books = librarymodel.GetItems(item, search);
                        break;
                    case "Subject":
                        item.Subject = model.query;
                        search = 1;
                        librarymodel.Books = librarymodel.GetItems(item, search);
                        break;
                    case "Author":
                        item.Author = model.query;
                        search = 2;
                        librarymodel.Books = librarymodel.GetItems(item, search);
                        break;
                }
                return View("Books", librarymodel);
            }

            return null;
        }
    }
}