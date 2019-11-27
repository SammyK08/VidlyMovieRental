using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyMovieRental.Models;

namespace VidlyMovieRental.Controllers
{
    public class UserProfileController : Controller
    {

        private readonly ApplicationDbContext _context;

        public UserProfileController()
        {
            _context = new ApplicationDbContext(); 
        }



        // GET: UserProfile
        public ActionResult Index(int id)
        {
            var customer = _context.Customers.Include(u => u.ApplicationUser).SingleOrDefault(c => c.Id == id);


            return View(customer);
        }

        public ActionResult Edit()
        {
            return View();
        }
    }
}