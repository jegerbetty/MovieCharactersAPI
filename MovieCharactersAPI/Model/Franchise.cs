using System.ComponentModel.DataAnnotations;

namespace MovieCharactersAPI.Model
{
    public class Franchise
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string? Description { get; set; }

        //Foreign key for one to many many between Franchise and Movie (one Franchise can have many Movies)
        public ICollection<Movie> Movies { get; set; }
    }
}
