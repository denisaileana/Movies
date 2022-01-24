using Movies.Data;
using Movies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.DAL
{
    public interface IMovieDetailsRepository
    {
        IEnumerable<MovieDetails> GetMovieDetails();
        MovieDetails GetMovieDetailsById(int movieDetailsId);
        void InsertMovieDetails(MovieDetails movieDetails);
        void UpdateMovieDetails(MovieDetails movieDetails);
        void DeleteMovieDetails(int movieDetailsId);
        void Save();


    }
    public class MovieDetailsRepository : IMovieDetailsRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public MovieDetailsRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void DeleteMovieDetails(int movieDetailsId)
        {
            var movieDetails = _dbContext.MovieDetails.Find(movieDetailsId);
            _dbContext.MovieDetails.Remove(movieDetails);
        }

        public MovieDetails GetMovieDetailsById(int movieDetailsId)
        {
            return _dbContext.MovieDetails.Find(movieDetailsId);
        }

        public IEnumerable<MovieDetails> GetMovieDetails()
        {
            return _dbContext.MovieDetails.ToList();
        }

        public void InsertMovieDetails(MovieDetails movieDetails)
        {
           _dbContext.MovieDetails.Add(movieDetails);
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void UpdateMovieDetails(MovieDetails movieDetails)
        {
            _dbContext.Entry(movieDetails).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
