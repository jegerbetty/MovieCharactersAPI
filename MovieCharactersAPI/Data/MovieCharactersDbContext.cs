using Microsoft.EntityFrameworkCore;
using MovieCharactersAPI.Model;

namespace MovieCharactersAPI.Data
{
    public class MovieCharactersDbContext : DbContext
    {
        public MovieCharactersDbContext(DbContextOptions options) : base(options)
        {
        }

        //public DbSet<Character> Characters { get; set; }

        //public DbSet<Movie> Movies { get; set; }

        //public DbSet<Franchise> Franchises { get; set; }
    }
}
