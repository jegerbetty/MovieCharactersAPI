using Microsoft.EntityFrameworkCore;
using MovieCharactersAPI.Model;

namespace MovieCharactersAPI.Data
{
    /// <summary>
    /// DBcontext class for creating tables in MovieCharactersDB database and adding seed data/dummy data to MovieCharactersDB tables
    /// </summary>
    public class MovieCharactersDbContext : DbContext
    {
        public MovieCharactersDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Character> Characters { get; set; }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Franchise> Franchises { get; set; }



        //ModelBuilder

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>().HasData(DataSeed.GetCharacters());
            modelBuilder.Entity<Franchise>().HasData(DataSeed.GetFranchises());
            modelBuilder.Entity<Movie>().HasData(DataSeed.GetMovies());
        }
    }
}
