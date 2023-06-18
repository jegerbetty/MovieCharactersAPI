using System.ComponentModel.DataAnnotations;

namespace MovieCharactersAPI.Model
{
    public class Movie
    {
        public int Id { get; set; }

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
        public Franchise? Franchise { get; set; }
        public int? FranchiseId { get; }

        public ICollection<Character> MovieCharacters { get; set; }
    }
}
