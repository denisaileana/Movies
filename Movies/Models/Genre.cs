using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string NumeGen { get; set; }
        public ICollection<MovieGenre> MovieGenres { get; set; }

    }
}
