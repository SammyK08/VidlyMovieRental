using AutoMapper;
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
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        public IEnumerable<MoviesDto> GetMovies()
        {
            return _context.Movies.ToList()
                                   .Select(Mapper.Map<Movie, MoviesDto>);
        }

        public IHttpActionResult GetMovie(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return NotFound();

            return Ok(Mapper.Map<Movie, MoviesDto>(movie));
        }

        [HttpPost]
        public IHttpActionResult CreateMovie(MoviesDto moviedto)
        {

            if (!ModelState.IsValid)
                return BadRequest();

            var movie = Mapper.Map<MoviesDto, Movie>(moviedto);

            _context.Movies.Add(movie);
            _context.SaveChanges();

            moviedto.Id = movie.Id;

            return Created(new Uri(Request.RequestUri + "/" + movie.Id), moviedto);

        }

        [HttpPut]
        public IHttpActionResult Updatemovie(int id, MoviesDto movieDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var movieInDb = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movieInDb == null)
                return NotFound();

            Mapper.Map<MoviesDto, Movie>(movieDto, movieInDb);

            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult DeleteMovie(int id)
        {

            var movieInDb = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movieInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Movies.Remove(movieInDb);
            _context.SaveChanges();

            return Ok();
        }
    }
}
