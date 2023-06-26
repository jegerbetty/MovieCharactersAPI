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

        //Navigation property to create Foreign key for one to many between Franchise and Movie (one Franchise can have many Movies)
        public ICollection<Movie> Movies { get; set; }
    }
}
