using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Identity;
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


            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "3747e4d8-78dc-4f55-8b38-ab5deea866fb",
                Name = "Administrator",
                NormalizedName = "Administrator".ToUpper()
            }, new IdentityRole
            {
                Id = "1ad6ef77-73fe-492f-bb24-ef5827eb7c8c",
                Name = "User",
                NormalizedName = "User".ToUpper()
            });

            var hasher = new PasswordHasher<ApplicationUser>();

            builder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = "101ab9b6-2b6e-494f-a72a-7ece0c979173",
                UserName = "admin",
                NormalizedUserName = "admin".ToUpper(),
                Email = "admin@admin.admin",
                NormalizedEmail = "admin@admin.admin".ToUpper(),
                PasswordHash = hasher.HashPassword(null, "parola")
            }, new ApplicationUser
            {
                Id = "69c272d3-1de9-4ca6-9c4d-61559167aa03",
                UserName = "user",
                NormalizedUserName = "user".ToUpper(),
                Email = "user@user.user",
                NormalizedEmail = "user@user.user".ToUpper(),
                PasswordHash = hasher.HashPassword(null, "parola")
            });

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    UserId = "101ab9b6-2b6e-494f-a72a-7ece0c979173",
                    RoleId = "3747e4d8-78dc-4f55-8b38-ab5deea866fb"
                },
                new IdentityUserRole<string>
                {
                    UserId = "101ab9b6-2b6e-494f-a72a-7ece0c979173",
                    RoleId = "1ad6ef77-73fe-492f-bb24-ef5827eb7c8c"
                },
                new IdentityUserRole<string>
                {
                    UserId = "69c272d3-1de9-4ca6-9c4d-61559167aa03",
                    RoleId = "1ad6ef77-73fe-492f-bb24-ef5827eb7c8c"
                }
            );
        }



    }
}
