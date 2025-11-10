using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistrationValidation.Models
{
    public class Regex
    {
        [Required]
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "Only letters and spaces allowed.")]
        public string Name { get; set; }

        [Required]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"^(?:\+88|88)?01[3-9]\d{8}$", ErrorMessage = "Invalid Bangladeshi mobile number.")]
        public string Phone { get; set; }

        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$",
            ErrorMessage = "Password must have uppercase, lowercase, number, and 8+ chars.")]
        public string Password { get; set; }

        [Required]
        [RegularExpression(@"^\d{4}$", ErrorMessage = "Postal code must be 4 digits.")]
        public string PostalCode { get; set; }
    }
}