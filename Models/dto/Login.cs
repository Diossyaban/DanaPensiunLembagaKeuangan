using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace DPLK.Models.Dto
{
    public class Login
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        [JsonProperty("email")] 
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [JsonProperty("password")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }


       
    }

    public class LoginType
    {
        public bool success { get; set; }
    }
}
