using MovieCharactersAPI.Model;
using System.ComponentModel.DataAnnotations;

namespace MovieCharactersAPI.DataTransferObjects.CharacterDTO
{
    public class DTOCreateCharacter //create a new character
    {

        [MaxLength(50)]
        public string FullName { get; set; }

        [MaxLength(50)]
        public string? Alias { get; set; }

        [MaxLength(20)]
        public string? Gender { get; set; }
        public string? CharacterPicture { get; set; }

        //Foreign key for many-to-many between Characters and Movies
        public ICollection<Movie> Movies { get; set; }
    }
}
