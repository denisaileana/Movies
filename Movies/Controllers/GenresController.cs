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
    public class GenresController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public GenresController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IQueryable<Genre> GetGenres() 
        { 
            return _dbContext.Genres; 
        }

        [HttpGet("{id}")]
        public Genre GetGenres(int id) 
        {
            return _dbContext.Genres.Find(id);
        }

        [HttpPost]
        public IActionResult Create(Genre genre)
        {
            _dbContext.Genres.Add(genre);
            _dbContext.SaveChanges();
            return Accepted();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Genre genre)
        {
            var originalGenre = _dbContext.Genres.Find(id);
            originalGenre.NumeGen = genre.NumeGen;
            _dbContext.SaveChanges();
            return Accepted();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var originalGenre = _dbContext.Genres.Find(id);
            _dbContext.Genres.Remove(originalGenre);
            _dbContext.SaveChanges();
            return Accepted();
        }
    }
}
