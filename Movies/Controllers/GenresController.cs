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
    public class GenresController : ControllerBase
    {
        private readonly UnitOfWork _unitOfWork;

        public GenresController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IEnumerable<Genre> GetGenres() 
        { 
            return _unitOfWork.GenreRepository.GetGenres(); 
        }

        [HttpGet("{id}")]
        public Genre GetGenres(int id) 
        {
            return _unitOfWork.GenreRepository.GetGenreById(id);
        }

        [HttpPost]
        public IActionResult Create(Genre genre)
        {
            _unitOfWork.GenreRepository.InsertGenre(genre);
            _unitOfWork.Save();
            return Accepted();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Genre genre)
        {
            _unitOfWork.GenreRepository.UpdateGenre(genre);
            _unitOfWork.Save();
            return Accepted();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _unitOfWork.GenreRepository.DeleteGenre(id);
            _unitOfWork.Save();
            return Accepted();
        }
    }
}
