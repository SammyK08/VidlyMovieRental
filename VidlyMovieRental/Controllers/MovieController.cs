using System;
using System.Collections.Generic;
using System.Data.Entity;
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


            var movies = _context.Movies.
                            Include(g=>g.Genre).
                            ToList();
            
            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.
                            Include(g=>g.Genre).
                           SingleOrDefault(m => m.Id == id);
            return View(movie);
        }
    }
}