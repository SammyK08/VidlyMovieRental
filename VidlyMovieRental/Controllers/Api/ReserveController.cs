using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using VidlyMovieRental.Models;


namespace VidlyMovieRental.Controllers.Api
{
    public class ReserveController : ApiController
    {

        private readonly ApplicationDbContext _context;

        public ReserveController()
        {
            _context = new ApplicationDbContext();
        }

        [System.Web.Http.HttpPost]
        public IHttpActionResult CreateReserve(int id)
        {
            
           
            return Ok();

        }
    }
}
