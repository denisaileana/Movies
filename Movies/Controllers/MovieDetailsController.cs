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
    public class MovieDetailsController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public MovieDetailsController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IQueryable<MovieDetails> GetMovieDetails() 
        { 
            return _dbContext.MovieDetails; 
        }

        [HttpGet("{id}")]
        public MovieDetails GetMovieDetails(int id) 
        {
            return _dbContext.MovieDetails.Find(id);
        }

        [HttpPost]
        public IActionResult Create(MovieDetails movieDetails)
        {
            _dbContext.MovieDetails.Add(movieDetails);
            _dbContext.SaveChanges();
            return Accepted();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, MovieDetails movieDetails)
        {
            var originalMovieDetails = _dbContext.MovieDetails.Find(id);
            originalMovieDetails.Description = movieDetails.Description;
            _dbContext.SaveChanges();
            return Accepted();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var originalMovieDetailst = _dbContext.MovieDetails.Find(id);
            _dbContext.MovieDetails.Remove(originalMovieDetailst);
            _dbContext.SaveChanges();
            return Accepted();
        }
    }
}
