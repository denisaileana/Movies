using Movies.Data;
using Movies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.DAL
{
    public interface IMovieCommentRepository
    {
        IEnumerable<MovieComment> GetMovieComments();
        MovieComment GetMovieCommentById(int movieCommentId);
        void InsertMovieComment(MovieComment movieComment);
        void UpdateMovieComment(MovieComment movieComment);
        void DeleteMovieComment(int movieCommentId);
        void Save();


    }
    public class MovieCommentRepository : IMovieCommentRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public MovieCommentRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void DeleteMovieComment(int movieCommentId)
        {
            var movieComment = _dbContext.MovieComments.Find(movieCommentId);
            _dbContext.MovieComments.Remove(movieComment);
        }

        public MovieComment GetMovieCommentById(int movieCommentId)
        {
            return _dbContext.MovieComments.Find(movieCommentId);
        }

        public IEnumerable<MovieComment> GetMovieComments()
        {
            return _dbContext.MovieComments.ToList();
        }

        public void InsertMovieComment(MovieComment movieComment)
        {
           _dbContext.MovieComments.Add(movieComment);
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void UpdateMovieComment(MovieComment movieComment)
        {
            _dbContext.Entry(movieComment).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
