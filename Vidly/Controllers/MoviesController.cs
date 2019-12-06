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
            var movie = _applicationDbContext.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return HttpNotFound("Movie not found");
            }
            return View(movie);
        }

        public ActionResult Create()
        {
            var genres = _applicationDbContext.Genres.ToList();
            MovieGenreViewModel movieGenreViewModel = new MovieGenreViewModel() { Genres = genres, };
            return View(movieGenreViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Movie movie)
        {
            var genres = _applicationDbContext.Genres.ToList();
            MovieGenreViewModel movieGenreViewModel = new MovieGenreViewModel(movie) { Genres = genres };
            if (ModelState.IsValid)
            {
                if (movie.Id == 0)
                {
                    _applicationDbContext.Movies.Add(movie);
                    _applicationDbContext.SaveChanges();
                    return RedirectToAction("Index");
                }

                var amovie = _applicationDbContext.Movies.Single(m => m.Id == movie.Id);
                amovie.DateAdded = movie.DateAdded;
                amovie.GenreId = movie.GenreId;
                amovie.NumberInStock = movie.NumberInStock;
                amovie.Name = movie.Name;
                amovie.ReleaseDate = movie.ReleaseDate;
                _applicationDbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(movieGenreViewModel);
        }

        public ActionResult Edit(int id)
        {
            var movie = _applicationDbContext.Movies.SingleOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            var genres = _applicationDbContext.Genres.ToList();
            var moviegenre = new MovieGenreViewModel(movie) { Genres = genres };

            return View("Create", moviegenre);
        }

        /* [HttpPost]
         public ActionResult Edit(Movie movie)
         {
             var amovie = _applicationDbContext.Movies.Single(m => m.Id == movie.Id);
             if (ModelState.IsValid)
             {
                 amovie.GenreId = movie.GenreId;
                 amovie.Name = movie.Name;
                 amovie.NumberInStock = movie.NumberInStock;
                 amovie.ReleaseDate = movie.ReleaseDate;
                 amovie.DateAdded = movie.DateAdded;
                 _applicationDbContext.SaveChanges();
                 return RedirectToAction("Index");
             }
             var genres = _applicationDbContext.Genres.ToList();
             var moviegenre = new MovieGenreViewModel() { Genres = genres, Movie = amovie };

             return View(moviegenre);

         }*/
    }
}
