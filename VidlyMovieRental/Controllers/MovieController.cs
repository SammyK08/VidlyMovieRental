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

        private ApplicationDbContext _context;

        public MovieController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Movie
        public ActionResult Index()
        {


            var movies = _context.Movies.ToList();
            
            return View(movies);
        }
    }
}