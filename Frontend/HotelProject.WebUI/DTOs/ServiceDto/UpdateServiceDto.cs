using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.DTOs.ServiceDto
{
    public class UpdateServiceDto
    {
        public int ServiceID { get; set; }
        [Required(ErrorMessage = "Please enter service icon link ")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Please enter service title ")]
        [StringLength(100, ErrorMessage = "Service title must have 100 charachters")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter service description ")]
        [StringLength(500, ErrorMessage = "Service description must have 500 charachters")]
        public string Description { get; set; }
    }
}
