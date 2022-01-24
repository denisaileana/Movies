using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Movies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieDetails> MovieDetails { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<MovieComment> MovieComments { get; set; }
        public DbSet<MovieGenre> MovieGenres { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<MovieGenre>().HasKey(mg => new { mg.MovieId, mg.GenreId });
            builder.Entity<MovieGenre>().HasOne(mg => mg.Genre).WithMany(g => g.MovieGenres).HasForeignKey(mg => mg.GenreId);
            builder.Entity<MovieGenre>().HasOne(mg => mg.Movie).WithMany(m => m.MovieGenres).HasForeignKey(mg => mg.MovieId);

        }

    }
}
