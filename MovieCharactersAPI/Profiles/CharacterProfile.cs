using AutoMapper;
using MovieCharactersAPI.DataTransferObjects.CharacterDTO;
using MovieCharactersAPI.Model;

namespace MovieCharactersAPI.Profiles
{
    public class CharacterProfile : Profile
    {
        public CharacterProfile()
        {
            CreateMap<Character, DTOCreateCharacter>().ReverseMap();

            CreateMap<Character, DTOReadCharacter>().ReverseMap();
        }
    }
}
