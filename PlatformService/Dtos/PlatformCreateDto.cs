using System.ComponentModel.DataAnnotations;

namespace PlatformService.Dtos
{
    // use required annotations because .Net has validation when creating db object
    public class PlatformCreateDto
    {       
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Publisher { get; set; }
        
        [Required]
        public string Cost { get; set; }
    }
}