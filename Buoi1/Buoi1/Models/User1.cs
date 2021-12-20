using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Buoi1.Models
{
    public class User1
    {
        [Required()]
        [StringLength(50)]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Pasword is required")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]

        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Pasword is required")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Compare("Password")]

        public string confirmPassword { get; set; }
    }
}