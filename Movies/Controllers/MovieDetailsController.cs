using Microsoft.AspNetCore.Authorization;
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
    [Authorize(Policy = "User")]
    public class MovieDetailsController : ControllerBase
    {
        private readonly UnitOfWork _unitOfWork;

        public MovieDetailsController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IEnumerable<MovieDetails> GetMovieDetails()
        { 
            return _unitOfWork.MovieDetailsRepository.GetMovieDetails(); 
        }

        [HttpGet("{id}")]
        public MovieDetails GetMovieDetails(int id) 
        {
            return _unitOfWork.MovieDetailsRepository.GetMovieDetailsById(id);
        }

        [HttpPost]
        public IActionResult Create(MovieDetails movieDetails)
        {
            _unitOfWork.MovieDetailsRepository.InsertMovieDetails(movieDetails);
            _unitOfWork.Save();
            return Accepted();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, MovieDetails movieDetails)
        {
            _unitOfWork.MovieDetailsRepository.UpdateMovieDetails(movieDetails);
            _unitOfWork.Save();
            return Accepted();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _unitOfWork.MovieDetailsRepository.DeleteMovieDetails(id);
            _unitOfWork.Save();
            return Accepted();
        }
    }
}
