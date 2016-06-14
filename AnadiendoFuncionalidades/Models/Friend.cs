using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AnadiendoFuncionalidades.Models
{
    
    public class Friend : IValidatableObject
    {
        [Required, StringLength(40)]
        public string Name { get; set; }

        [Range(1, 120)]
        public int Age { get; set; }

        [EmailAddress, StringLength(50)]
        public string email { get; set; }

        [Phone]
        public string telefono { get; set;  }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(email==null && telefono==null)
                yield return new ValidationResult(
                    "Introduce el email o telefono",        // Error message
                    new[] { "email", "telefono" });            // Invalid property
        }
    }
}