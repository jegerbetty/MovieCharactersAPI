﻿using System.ComponentModel.DataAnnotations;

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
        
        //Foreign key for one to many between Franchise to Movie (Movie is dependent)
        public Franchise? Franchise { get; set; }

        //Foreign key for many-to-many between Characters and Movies
        public ICollection<Character> Characters { get; set; }
    }
}
