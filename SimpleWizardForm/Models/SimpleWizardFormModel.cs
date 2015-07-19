using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SimpleWizardForm.Models
{
    public class SimpleWizardFormModel : IValidatableObject
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Street Address")]
        public string Address { get; set; }

        [Required]
        [RegularExpression(@"^\d{4}$", ErrorMessage = "Postal code must consist of 4 digits.")]
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }

        [Required]
        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "Home Phone")]
        public string Phone { get; set; }

        [Display(Name = "Mobile Phone")]
        public string Mobile { get; set; }

        [Display(Name = "I'm at least 18 years old?")]
        public bool HasTurned18 { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (!HasTurned18)
                yield return new ValidationResult("You must be 18 or older.", new[] { "HasTurned18" });
        }
    }
}