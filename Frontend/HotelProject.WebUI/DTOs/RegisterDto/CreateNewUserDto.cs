using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.DTOs.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage = "Name field should not be empty")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Surname field should not be empty")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Username field should not be empty")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Mail field should not be empty")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Password field should not be empty")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Confirm Password field should not be empty")]
        [Compare("Password", ErrorMessage = "Passwords doesn't match")]
        public string ConfirmPassword { get; set; }
    }
}
