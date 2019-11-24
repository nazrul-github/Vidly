using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        /*    public ActionResult Random()
            {
                Movie newMovie = new Movie() { Name = "Shrek!" };

                List<AllCustomer> allCustomer = new List<AllCustomer>{new AllCustomer{Name = "AllCustomer One"},new AllCustomer{Name = "AllCustomer Two"}};

                var viewModel = new RandomMovieViewModel{Movie = newMovie,Customers = allCustomer};


                return View(viewModel);
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

            [Route("movies/released/{year:regex(\\d{4})}/{month:range(1,12)}")]
            public ActionResult ByReleaseDate(int year, int month)
            {
                return Content(year + "/" + month);
            }*/
        List<Customer> alCustomers = new List<Customer> { new Customer { Name = "John Smith", Id = 1 }, new Customer { Name = "Mary Williams", Id = 2 } };
        [Route("movies/customer")]
        public ActionResult AllCustomer()
        {
            return View(alCustomers);
        }

        [Route("movies/details/{id}")]
        public ActionResult Details(int id)
        {
            Customer aCustomer = alCustomers.Find(cus => cus.Id == id);
            return View(aCustomer);
        }
    }
}