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
    public class MovieCommentsController : ControllerBase
    {
        private readonly UnitOfWork _unitOfWork;
     
        public MovieCommentsController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IEnumerable<MovieComment> GetMovieComments() 
        { 
            return _unitOfWork.MovieCommentRepository.GetMovieComments(); 
        }

        [HttpGet("{id}")]
        public MovieComment GetMovieComments(int id) 
        {
            return _unitOfWork.MovieCommentRepository.GetMovieCommentById(id);
        }

        [HttpPost]
        public IActionResult Create(MovieComment movieComment)
        {
            _unitOfWork.MovieCommentRepository.InsertMovieComment(movieComment);
            _unitOfWork.Save();
            return Accepted();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, MovieComment movieComment)
        {
            _unitOfWork.MovieCommentRepository.UpdateMovieComment(movieComment);
            _unitOfWork.Save();
            return Accepted();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _unitOfWork.MovieCommentRepository.DeleteMovieComment(id);
            _unitOfWork.Save();
            return Accepted();
        }
    }
}
