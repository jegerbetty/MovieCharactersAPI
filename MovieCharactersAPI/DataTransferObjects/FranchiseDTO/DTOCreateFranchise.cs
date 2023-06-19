using MovieCharactersAPI.Model;
using System.ComponentModel.DataAnnotations;

namespace MovieCharactersAPI.DataTransferObjects.FranchiseDTO
{
    public class DTOCreateFranchise //create a new franchise
    {
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string? Description { get; set; }

        //Foreign key for one to many many between Franchise and Movie (one Franchise can have many Movies)
        public ICollection<Movie> Movies { get; set; }
    }
}
