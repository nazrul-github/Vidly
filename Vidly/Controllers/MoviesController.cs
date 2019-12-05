using System;
using System.Collections.Generic;
using System.Data.Entity;
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
                Movie newMovie = new Movie() { MembershipName = "Shrek!" };

                List<Customer> allCustomer = new List<Customer>{new Customer{MembershipName = "Customer One"},new Customer{MembershipName = "Customer Two"}};

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
                    sortby = "MembershipName";
                }

                return Content(string.Format("PageIndex={0}&sortBy={1}", pageIndex, sortby));
                ;
            }

            [Route("movies/released/{year:regex(\\d{4})}/{month:range(1,12)}")]
            public ActionResult ByReleaseDate(int year, int month)
            {
                return Content(year + "/" + month);
            }*/
        /* public ActionResult Customer()
         {
             List<Customer> alCustomers = new List<Customer>{new Customer{Name = "John Smith"},new Customer{Name = "Mary Williams"}};
             return View(alCustomers);*/

        private ApplicationDbContext _applicationDbContext;

        public MoviesController()
        {
            _applicationDbContext = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _applicationDbContext.Dispose();
        }

        public ActionResult Index()
        {
            var movies = _applicationDbContext.Movies.Include(m => m.Genre).ToList();
            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movie = _applicationDbContext.Movies.Include(m => m.Genre).SingleOrDefault(m=>m.Id == id);
            if (movie==null)
            {
                return HttpNotFound("Movie not found");
            }
            return View(movie);
        }
    }
}
