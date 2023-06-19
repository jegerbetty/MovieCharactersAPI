using AutoMapper;
using MovieCharactersAPI.DataTransferObjects.CharacterDTO;
using MovieCharactersAPI.Model;

namespace MovieCharactersAPI.Profiles
{
    public class CharacterProfile : Profile
    {
        public CharacterProfile() 
        {
            //mapping data from Character to DTOCreateCharacter
            CreateMap<Character, DTOCreateCharacter>();

            //mapping data from Character to DTOReadCharacter
            CreateMap<Character, DTOReadCharacter>();
        }
    }
}
