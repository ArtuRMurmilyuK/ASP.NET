using System;
using System.ComponentModel.DataAnnotations;

namespace FormsAndValidation.Models
{
    public class RegistrationBildingModel
    {
        [Required]
        public string Name { get; set;  }
        
        [Required]
        public string Surname { get;set; }
        
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required]
        public DateTime Date { get; set; }
    }
}
