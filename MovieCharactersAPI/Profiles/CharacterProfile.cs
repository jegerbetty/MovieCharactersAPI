using AutoMapper;
using MovieCharactersAPI.DataTransferObjects.CharacterDTO;
using MovieCharactersAPI.Model;

namespace MovieCharactersAPI.Profiles
{
    public class CharacterProfile : Profile
    {
        public CharacterProfile() 
        {
            //mapping data from DTOCreateCharacter to Character
            CreateMap<DTOCreateCharacter, Character>().ReverseMap();

            //mapping data from Character to DTOReadCharacter
            CreateMap<Character, DTOReadCharacter>().ReverseMap();
        }
    }
}
