using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyMovieStore.Models;
using MyMovieStore.ViewModels;

namespace MyMovieStore.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name="Shrek!" };
            var customers = new List<Customer>()
            {
                new Customer{Name="Customer 1"},
                new Customer{Name="Customer 2"},
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers,
            };
            return View(viewModel);
            //return Content("Hello world");
            //return HttpNotFound();
        }


        public ViewResult Index()
        {
            var movie = GetMovies();
            return View(movie);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie{Id=1,Name="Shrek"},
                new Movie{Id=1,Name="Wall-e"}
            };
        }
        //public actionresult index(int? pageindex, string sortby)
        //{
        //    if (!pageindex.hasvalue)
        //        pageindex = 1;
        //    if (string.isnullorwhitespace(sortby))
        //        sortby = "name";
        //    return content(string.format("pageindex={0} & sortby={1}", pageindex, sortby));

        //}

        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        public ActionResult ByReleasedDate(int year,int month)
        {
            return Content(year+"/"+month);
        }
    }
}