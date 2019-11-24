using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            Movie newMovie = new Movie() { Name = "Shrek!" };

            return View(newMovie);
        }

        public ActionResult Edit(int id)
        {
            return Content("id:" + id);
        }
        public ActionResult Index(int? pageIndex, string sortby)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (string.IsNullOrWhiteSpace(sortby))
            {
                sortby = "Name";
            }

            return Content(string.Format("PageIndex={0}&sortBy={1}", pageIndex, sortby));
            ;
        }

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}