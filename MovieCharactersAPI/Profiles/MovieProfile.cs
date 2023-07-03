using AutoMapper;
using MovieCharactersAPI.DataTransferObjects.MovieDTO;
using MovieCharactersAPI.Model;

namespace MovieCharactersAPI.Profiles
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
            //mapping data from DTOCreateMovie to Movie
            CreateMap<DTOCreateMovie, Movie>().ReverseMap();

            //mapping data from Movie to DTOReadMovie
            CreateMap<Movie, DTOReadMovie>().ReverseMap();
        }
    }
}
