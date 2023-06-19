using AutoMapper;
using MovieCharactersAPI.DataTransferObjects.FranchiseDTO;
using MovieCharactersAPI.Model;

namespace MovieCharactersAPI.Profiles
{
    public class FranchiseProfile : Profile
    {
        public FranchiseProfile()
        {
            //mapping data from Franchise to DTOCreateFranchise
            CreateMap<Franchise, DTOCreateFranchise>();

            //mapping data from Franchise to DTOReadFranchise
            CreateMap<Franchise, DTOReadFranchise>();
        }
    }
}
