using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VidlyMovieRental.Dtos;
using VidlyMovieRental.Models;

namespace VidlyMovieRental.Controllers.Api
{
    public class NewRetalController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRetalController()
        {
            _context = new ApplicationDbContext();
        }

       
        [HttpGet]
        public IHttpActionResult GetRental(int id)
        {

            return Ok();
        }

        [HttpPost]
        public IHttpActionResult CreateRental(NewRentalDto newRental)
        {

           
            var customer = _context.Customers
                                .SingleOrDefault(c => c.Id == newRental.CustomerId);
                                

            var movies = _context.Movies.Where(
                m => newRental.MoviesIds.Contains(m.Id)).ToList();
            
            foreach(var movie in movies)
            {
                if (movie.Avilability == 0)
                    return BadRequest("Movies is not avilable");

                movie.Avilability--;
                var rental = new Rental
                {
                    Customer=customer,
                    Movie=movie,
                    DateRented=DateTime.Now
                };

                _context.Rentals.Add(rental);
            }

            _context.SaveChanges();
           

            return Ok();
        }

        [HttpPut]
        public IHttpActionResult UpdateRental(int id)
        {
            return Ok();
        }

    }
}
