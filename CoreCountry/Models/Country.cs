using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreCountry.Models
{
    public class Country
    {

        [Required(ErrorMessage = "Please provide a number")]
        [Range(0,300)]
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please provide the name of the country")]
        [StringLength(30, MinimumLength =2)]

        [Display(Name = "Country Name")]
        public string CName { get; set; }

        [Required(ErrorMessage = "Please provide a name for the continent")]
        [StringLength(50, MinimumLength =2)]

        public string Continent { get; set; }

        [Display(Name = "Requires Travel Visa")]
        public bool? RequireTravelVisa { get; set; }
        public ICollection<Destination> Destinations { get; set; }

        public static ValidationResult CNameValidation(string CName, ValidationContext context)
        {
            if (string.IsNullOrWhiteSpace(CName))
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("Country Code should not be blank");

        }

    }
}
