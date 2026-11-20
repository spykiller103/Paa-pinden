using System.ComponentModel.DataAnnotations;


namespace PaaPinden.DTO
{
    public class PindDTO
    {
      
        [Required(ErrorMessage = "Du skal vælge en video eller et billede at slå op")]
        public IFormFile? MediaType { get; set; }

        public string? Description { get; set; }

    }
}
