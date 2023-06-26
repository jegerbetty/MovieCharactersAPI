using System.ComponentModel.DataAnnotations;

namespace MovieCharactersAPI.Model
{
    public class Character
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string FullName { get; set; }

        [MaxLength(50)]
        public string? Alias { get; set; }

        [MaxLength(20)]
        public string? Gender { get; set; }
        public string? CharacterPicture { get; set; }

        //Navigation property to create Foreign key for many-to-many between Characters and Movies
        public ICollection<Movie> Movies { get; set; } //New table CharacterMovie created and Foreign Key MoviesId created in migration - see migration ForeignKeys
    }
}
