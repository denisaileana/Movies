using Microsoft.EntityFrameworkCore;
using Movies.Data;
using Movies.Models;
using System.Collections.Generic;
using System.Linq;

namespace Movies.DAL
{
    public interface IMovieRepository
    {
        IEnumerable<Movie> GetMovies();
        Movie GetMovieById(int movieId);
        void InsertMovie(Movie movie);
        void UpdateMovie(Movie movie);
        void DeleteMovie(int movieId);
        void Save();
        IEnumerable<Movie> GetBestMovies();
    }
    public class MovieRepository : IMovieRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public MovieRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void DeleteMovie(int movieId)
        {
            var movie = _dbContext.Movies.Find(movieId);
            _dbContext.Movies.Remove(movie);
        }

        public IEnumerable<Movie> GetBestMovies()
        {
            // cele mai bun filme, dovedit stiintific, sunt cele cu cele mai multe comentarii ce sunt comedii
            var top5filmeComedieComentariiIds = _dbContext.Movies
                .Where(x => x.MovieGenres.Any(y => string.Equals(y.Genre.NumeGen, "comedie")))
                .SelectMany(x => x.Comments)
                .GroupBy(x => x.MovieId)
                .Select(x => new
                {
                    x.Key,
                    Numar = x.Count()
                })
                .OrderByDescending(x => x.Numar)
                .Select(x => x.Key)
                .ToList();
            var top5filmeRomanticeComentariiIds = _dbContext.Movies
                .Where(x => x.MovieGenres.Any(y => string.Equals(y.Genre.NumeGen, "romantic")))
                .SelectMany(x => x.Comments)
                .GroupBy(x => x.MovieId)
                .Select(x => new
                {
                    x.Key,
                    Numar = x.Count()
                })
                .OrderByDescending(x => x.Numar)
                .Select(x => x.Key)
                .ToList();

            var top5filmeComedieRomanticaIds = top5filmeComedieComentariiIds.Join(top5filmeRomanticeComentariiIds, x => x, x => x, (a, b) => a).Take(5).ToList();

            return _dbContext.Movies
                .Include(x => x.MovieGenres).ThenInclude(x => x.Genre)
                .Include(x => x.Details)
                .Include(x => x.Comments)
                .Where(x => top5filmeComedieRomanticaIds.Contains(x.Id));
        }

        public Movie GetMovieById(int movieId)
        {
            return _dbContext.Movies.Find(movieId);
        }

        public IEnumerable<Movie> GetMovies()
        {
            return _dbContext.Movies.ToList();
        }

        public void InsertMovie(Movie movie)
        {
            _dbContext.Movies.Add(movie);
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void UpdateMovie(Movie movie)
        {
            _dbContext.Entry(movie).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
