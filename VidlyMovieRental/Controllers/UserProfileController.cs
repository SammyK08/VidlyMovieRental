using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
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
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();
            var userProfile = _context.Users.SingleOrDefault(u => u.Id == userId);

            return View(userProfile);
        }

        public ActionResult Edit()
        {
            return View();
        }
    }
}