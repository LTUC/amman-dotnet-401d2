using System.ComponentModel.DataAnnotations;

namespace AuthMVCDemo.Models.DTOs
{
    public class LoginData
    {
        [Required]
        public string Username { get; set; }

        public string Password { get; set; }
    }
}
