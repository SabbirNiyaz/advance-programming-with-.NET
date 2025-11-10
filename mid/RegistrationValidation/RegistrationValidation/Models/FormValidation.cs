using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistrationValidation.Models
{
    public class FormValidation
    {
        [Required]
        [Range(1,40)]
        public int Id { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string Profession { get; set; }

        [Required]
        public string[] Hobbies { get; set; }
    }
}