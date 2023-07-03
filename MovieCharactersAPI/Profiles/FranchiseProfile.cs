using AutoMapper;
using MovieCharactersAPI.DataTransferObjects.FranchiseDTO;
using MovieCharactersAPI.Model;

namespace MovieCharactersAPI.Profiles
{
    public class FranchiseProfile : Profile
    {
        public FranchiseProfile()
        {
            //mapping data from DTOCreateFranchise to Franchise
            CreateMap<DTOCreateFranchise, Franchise>().ReverseMap();

            //mapping data from Franchise to DTOReadFranchise
            CreateMap<Franchise, DTOReadFranchise>().ReverseMap();
        }
    }
}
