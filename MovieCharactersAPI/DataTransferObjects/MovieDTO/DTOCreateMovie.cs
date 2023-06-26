using MovieCharactersAPI.Model;
using System.ComponentModel.DataAnnotations;

namespace MovieCharactersAPI.DataTransferObjects.MovieDTO
{
    public class DTOCreateMovie
    {
        [MaxLength(50)]
        public string MovieTitle { get; set; }

        [MaxLength(50)]
        public string MovieGenre { get; set; }

        [MaxLength(4)]
        public int ReleaseYear { get; set; }

        [MaxLength(50)]
        public string Director { get; set; }
        public string? MoviePicture { get; set; }
        public string? MovieTrailer { get; set; }

        //Collection of entities creates circular reference error - cannot be included here
        //public ICollection<Character> Characters { get; set; }
    }
}
