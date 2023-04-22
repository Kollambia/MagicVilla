using System.ComponentModel.DataAnnotations;
namespace MagicVilla_WebAPI.Controllers.DTO
{
    public class VillaDTO
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        public int Occupacity { get; set; }
        public int Sqft { get; set; }

    }
}
