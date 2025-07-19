﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Register_Login_Test.Models
{
    public class LoginVM
    {
        [Required(ErrorMessage ="Username is required")]
     
        public string? Username { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [DisplayName("Remember Me")]
        public bool Rememberme { get; set; }
    }
}
