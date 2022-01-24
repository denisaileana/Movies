using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public MovieDetails Details { get; set; }
        public ICollection<MovieComment> Comments { get; set; }
        public ICollection<MovieGenre> MovieGenres { get; set; }
    }
}
