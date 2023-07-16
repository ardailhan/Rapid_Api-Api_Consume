using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.DTOs.ServiceDto
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage = "Please enter service icon link ")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Please enter service title ")]
        [StringLength(100, ErrorMessage = "Service title must have 100 charachters")]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
