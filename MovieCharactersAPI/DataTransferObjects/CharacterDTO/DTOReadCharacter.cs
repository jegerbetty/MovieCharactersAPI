using MovieCharactersAPI.Model;
using System.ComponentModel.DataAnnotations;

namespace MovieCharactersAPI.DataTransferObjects.CharacterDTO
{
    public class DTOReadCharacter //Bring data from Character table
    {
        [MaxLength(50)]
        public string FullName { get; set; }

        [MaxLength(50)]
        public string? Alias { get; set; }

        [MaxLength(20)]
        public string? Gender { get; set; }
        public string? CharacterPicture { get; set; }

        //Collection of entities creates circular reference error - cannot be included here
        //public ICollection<Movie> Movies { get; set; }
    }
}
