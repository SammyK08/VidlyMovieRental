﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyMovieRental.Models;

namespace VidlyMovieRental.Controllers
{
    public class CustomerController : Controller
    {

        private ApplicationDbContext _context;

        public CustomerController()
        {
            _context = new ApplicationDbContext();
           
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customer
        public ActionResult Index()
        {
            var customer = _context.Customers.
                           Include(c => c.MembershipType).
                           ToList();

            return View(customer);
        }
        public ActionResult Details(int id)
        {
            var customer = _context.Customers.
                            SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();
            return View(customer);
        }
                           
    }
}