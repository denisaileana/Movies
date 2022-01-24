using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movies.DAL;
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
        private readonly UnitOfWork _unitOfWork;

        public MoviesController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IEnumerable<Movie> GetMovies() 
        {
            return _unitOfWork.MovieRepository.GetMovies(); 
        }

        [HttpGet("best")]
        public IEnumerable<Movie> GetBestMovies()
        {
            return _unitOfWork.MovieRepository.GetBestMovies();
        }

        [HttpGet("{id}")]
        public Movie GetMovie(int id) 
        {
            return _unitOfWork.MovieRepository.GetMovieById(id);
        }

        [HttpPost]
        public IActionResult Create(Movie movie)
        {
            _unitOfWork.MovieRepository.InsertMovie(movie);
            _unitOfWork.Save();
            return Accepted();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Movie movie)
        {
            _unitOfWork.MovieRepository.UpdateMovie(movie);
            _unitOfWork.Save();
            return Accepted();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _unitOfWork.MovieRepository.DeleteMovie(id);
            _unitOfWork.Save();
            return Accepted();
        }
    }
}
