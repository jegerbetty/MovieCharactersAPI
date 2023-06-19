using MovieCharactersAPI.Model;

namespace MovieCharactersAPI.Data
{
    public class DataSeed
    {
        //Seed data/dummy data for Characters, Franchises, and Movies
        public static List<Character> GetCharacters()
        {
            List<Character> characterList = new List<Character>()
            {
                new Character() { FullName = "Gandalf the Grey", Alias = "The White Wizard", Gender = "Male", CharacterPicture = "https://static.wikia.nocookie.net/lotr/images/e/e7/Gandalf_the_Grey.jpg/revision/latest?cb=20121110131754"},
                new Character() { FullName = "Harry Potter", Alias = "The Chosen One", Gender = "Male", CharacterPicture = "https://periskop.no/wp-content/uploads/2021/02/Harry-Potter-med-tryllestaven.jpg"},
                new Character() { FullName = "Voldemort", Alias = "He Who Shall Not Be Named", Gender = "Male", CharacterPicture = "https://upload.wikimedia.org/wikipedia/en/a/a3/Lordvoldemort.jpg"}
            };
            return characterList;
        }

        public static List<Franchise> GetFranchise()
        {
            List<Franchise> franchiseList = new List<Franchise>()
            {
                new Franchise() { Name = "Gandalf the Grey", Description = "The White Wizard"},
                new Franchise() { Name = "Harry Potter", Description = "The Chosen One"}
            };
            return franchiseList;
        }

        public static List<Movie> GetMovies()
        {
            List<Movie> movieList = new List<Movie>()
            {
                new Movie() {MovieTitle = "The Fellowship of the Ring", MovieGenre = "Fantasy", ReleaseYear=2001, Director="Peter Jackson", MoviePicture="https://m.media-amazon.com/images/I/51ILUdMuieL._AC_UF1000,1000_QL80_.jpg", MovieTrailer="https://www.youtube.com/watch?v=V75dMMIW2B4&ab_channel=Movieclips"},
                new Movie() {MovieTitle = "The Return of the King", MovieGenre = "Fantasy", ReleaseYear=2003, Director="Peter Jackson", MoviePicture="https://m.media-amazon.com/images/I/91+ni21hctL._UF1000,1000_QL80_.jpg", MovieTrailer="https://www.youtube.com/watch?v=y2rYRu8UW8M&ab_channel=RottenTomatoesClassicTrailers"},
                new Movie() {MovieTitle = "Harry Potter and the Goblet of Fire", MovieGenre = "Magical Adventure", ReleaseYear=2005, Director="Mike Newell", MoviePicture="https://upload.wikimedia.org/wikipedia/en/c/c9/Harry_Potter_and_the_Goblet_of_Fire_Poster.jpg", MovieTrailer="https://www.youtube.com/watch?v=3EGojp4Hh6I&ab_channel=RottenTomatoesClassicTrailers"}
            };
            return movieList;
        }
    }
}
