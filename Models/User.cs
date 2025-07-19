using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Register_Login_Test.Models
{
    public class User:IdentityUser
    {
        [RegularExpression("^[a-zA-Z0-9 ]*$", ErrorMessage = "Name can only contain letters, numbers, and spaces")]
        public string? Name { get; set; }
        public string? Address { get; set; }
    }
}
