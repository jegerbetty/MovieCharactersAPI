using AutoMapper;
using MovieCharactersAPI.DataTransferObjects.FranchiseDTO;
using MovieCharactersAPI.Model;

namespace MovieCharactersAPI.Profiles
{
    public class FranchiseProfile : Profile
    {
        public FranchiseProfile()
        {
            CreateMap<Franchise, DTOCreateFranchise>().ReverseMap();

            CreateMap<Franchise, DTOReadFranchise>().ReverseMap();
        }
    }
}
