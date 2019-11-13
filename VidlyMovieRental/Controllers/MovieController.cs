using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyMovieRental.Models;
using VidlyMovieRental.ViewModel;

namespace VidlyMovieRental.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Random()
        {

            var movie = new Movie() { Id = 1, Name = "mad max" };

            var customers = new List<Customer>()
            {
                new Customer{Id=1, Name="samraj"},
                new Customer{Id=2, Name="beeva"}
            };

            var viewModel = new RandomViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }
    }
}