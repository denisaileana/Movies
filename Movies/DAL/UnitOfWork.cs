using Movies.Data;

namespace Movies.DAL
{
    public class UnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        private IGenreRepository _genreRepository;
        private IMovieRepository _movieRepository;
        private IMovieCommentRepository _movieCommentRepository;
        private IMovieDetailsRepository _movieDetailsRepository;

        public IGenreRepository GenreRepository
        {
            get
            {
                if (_genreRepository == null)
                {
                    _genreRepository = new GenreRepository(_dbContext);
                }
                return _genreRepository;
            }
        }

        public IMovieRepository MovieRepository
        {
            get
            {
                if (_movieRepository == null)
                {
                    _movieRepository = new MovieRepository(_dbContext);
                }
                return _movieRepository;
            }
        }

        public IMovieCommentRepository MovieCommentRepository
        {
            get
            {
                if (_movieCommentRepository == null)
                {
                    _movieCommentRepository = new MovieCommentRepository(_dbContext);
                }
                return _movieCommentRepository;
            }
        }

        public IMovieDetailsRepository MovieDetailsRepository
        {
            get
            {
                if (_movieDetailsRepository == null)
                {
                    _movieDetailsRepository = new MovieDetailsRepository(_dbContext);
                }
                return _movieDetailsRepository;
            }
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
