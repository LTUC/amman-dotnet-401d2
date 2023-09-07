using System.ComponentModel.DataAnnotations;

namespace AuthMVCDemo.Models.DTOs
{
    public class RegisterUserDto
    {
        [Required]
        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public List<string> Roles { get; set; }
    }
}
