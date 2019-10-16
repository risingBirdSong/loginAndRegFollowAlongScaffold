using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoginRegistration.Models
{
    public class MyUser
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password must match")]
        public string ConfirmPassword { get; set; }

        [Required]
        [MinLength(4)]
        public string FirstName { get; set; }


        [Required]
        [MinLength(4)]
        public string LastName{ get; set; }

    }
}
