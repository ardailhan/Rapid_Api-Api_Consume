using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.DTOs.LoginDto
{
    public class LoginUserDto
    {
        [Required(ErrorMessage = "Please enter your username")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Please enter your password")]
        public string Password { get; set; }
    }
}
