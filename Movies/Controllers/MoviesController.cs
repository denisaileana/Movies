using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movies.Data;
using Movies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public MoviesController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IQueryable<Movie> GetMovies() 
        { 
            return _dbContext.Movies; 
        }

        [HttpGet("{id}")]
        public Movie GetMovie(int id) 
        {
            return _dbContext.Movies.Find(id);
        }

        [HttpPost]
        public IActionResult Create(Movie movie)
        {
            _dbContext.Movies.Add(movie);
            _dbContext.SaveChanges();
            return Accepted();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Movie movie)
        {
            var originalMovie = _dbContext.Movies.Find(id);
            originalMovie.Title = movie.Title;
            originalMovie.Year = movie.Year;
            _dbContext.SaveChanges();
            return Accepted();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var originalMovie = _dbContext.Movies.Find(id);
            _dbContext.Movies.Remove(originalMovie);
            _dbContext.SaveChanges();
            return Accepted();
        }
    }
}
