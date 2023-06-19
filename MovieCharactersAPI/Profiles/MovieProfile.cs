using AutoMapper;
using MovieCharactersAPI.DataTransferObjects.MovieDTO;
using MovieCharactersAPI.Model;

namespace MovieCharactersAPI.Profiles
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
            //mapping data from Movie to DTOCreateMovie
            CreateMap<Movie, DTOCreateMovie>().ReverseMap();

            //mapping data from Movie to DTOReadMovie
            CreateMap<Movie, DTOReadMovie>().ReverseMap();
        }
    }
}
