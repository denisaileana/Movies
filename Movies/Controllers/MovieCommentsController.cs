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
    public class MovieCommentsController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public MovieCommentsController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IQueryable<MovieComment> GetMovieComments() 
        { 
            return _dbContext.MovieComments; 
        }

        [HttpGet("{id}")]
        public MovieComment GetMovieComments(int id) 
        {
            return _dbContext.MovieComments.Find(id);
        }

        [HttpPost]
        public IActionResult Create(MovieComment movieComment)
        {
            _dbContext.MovieComments.Add(movieComment);
            _dbContext.SaveChanges();
            return Accepted();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, MovieComment movieComment)
        {
            var originalMovieComment = _dbContext.MovieComments.Find(id);
            originalMovieComment.NumePersoana = movieComment.NumePersoana;
            originalMovieComment.Comentariu = movieComment.Comentariu;
            _dbContext.SaveChanges();
            return Accepted();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var originalMovieComment = _dbContext.MovieComments.Find(id);
            _dbContext.MovieComments.Remove(originalMovieComment);
            _dbContext.SaveChanges();
            return Accepted();
        }
    }
}
