using MyMovieStore.Models;
using System;
using MyMovieStore.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using System.Data.Entity;

namespace MyMovieStore.API
{
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            this._context = new ApplicationDbContext();
        }

        //Get api/moives
        public IHttpActionResult GetMovies()
        {
            var movieDto=_context.Movies.Include(m=>m.Genre)
                                        .ToList()
                                        .Select(Mapper.Map<Movie,MovieDto>);
            return Ok(movieDto);
        }

        //Get api/Movies/1
        public IHttpActionResult GetMovie(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return NotFound();

            return Ok(Mapper.Map<Movie, MovieDto>(movie));
        }

        //Get api/Movies
        [HttpPost]
        public IHttpActionResult CreateMovie(MovieDto movieDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            
            movieDto.DateAdded = DateTime.Now;
            var movie = Mapper.Map<MovieDto, Movie>(movieDto);
            
            _context.Movies.Add(movie);
            _context.SaveChanges();
            
            movieDto.Id = movie.Id;
            return Created(new Uri(Request.RequestUri + "/" + movieDto), movieDto);
        }
        //Put api/Movies/1
        [HttpPut]
        public IHttpActionResult UpdateMovie(int id, MovieDto movieDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var movieInDb = _context.Movies.Find(id);

            if (movieInDb == null)
                return NotFound();

            Mapper.Map(movieDto, movieInDb);
            _context.SaveChanges();
            return Ok();
        }

        //Delete api/movies/1
        [HttpDelete]
        public IHttpActionResult DeleteMovie(int id)
        {
            var movieIndb = _context.Movies.Find(id);
            if (movieIndb == null)
                return NotFound();

            _context.Movies.Remove(movieIndb);
            _context.SaveChanges();
            return Ok();
        } 
    }
}
