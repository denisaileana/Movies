using Movies.Data;
using Movies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.DAL
{
    public interface IGenreRepository
    {
        IEnumerable<Genre> GetGenres();
        Genre GetGenreById(int genreId);
        void InsertGenre(Genre genre);
        void UpdateGenre(Genre genre);
        void DeleteGenre(int genreId);
        void Save();


    }
    public class GenreRepository : IGenreRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public GenreRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void DeleteGenre(int genreId)
        {
            var genre = _dbContext.Genres.Find(genreId);
            _dbContext.Genres.Remove(genre);
        }

        public Genre GetGenreById(int genreId)
        {
            return _dbContext.Genres.Find(genreId);
        }

        public IEnumerable<Genre> GetGenres()
        {
            return _dbContext.Genres.ToList();
        }

        public void InsertGenre(Genre genre)
        {
           _dbContext.Genres.Add(genre);
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void UpdateGenre(Genre genre)
        {
            _dbContext.Entry(genre).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
