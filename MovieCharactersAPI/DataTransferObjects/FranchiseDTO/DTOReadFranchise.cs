using MovieCharactersAPI.Model;
using System.ComponentModel.DataAnnotations;

namespace MovieCharactersAPI.DataTransferObjects.FranchiseDTO
{
    public class DTOReadFranchise
    {
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string? Description { get; set; }

        //Collection of entities creates circular reference error - cannot be included here
        //public ICollection<Movie> Movies { get; set; }
    }
}
