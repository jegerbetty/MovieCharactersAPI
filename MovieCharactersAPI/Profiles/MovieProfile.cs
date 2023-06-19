using AutoMapper;
using MovieCharactersAPI.DataTransferObjects.MovieDTO;
using MovieCharactersAPI.Model;

namespace MovieCharactersAPI.Profiles
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
            CreateMap<Movie, DTOCreateMovie>().ReverseMap();

            CreateMap<Movie, DTOReadMovie>().ReverseMap();
        }
    }
}
