﻿using System.ComponentModel.DataAnnotations;

namespace Task_Management_System.ViewModel
{
    public class RegisterVM
    {
        [Required]
        public string? Name { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwords don't match.")]
        [Display(Name = "Confirm Paasword")]
        public string? ConfirmPassword { get; set; }
       
    }
}
