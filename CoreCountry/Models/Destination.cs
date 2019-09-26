using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreCountry.Models
{
    public class Destination
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string DName { get; set; }

        [Required]
        public decimal Budget { get; set; }

        [Required]
        [StringLength(13)]
        [Display(Name = "City Code")]
        public string CityCode { get; set; }

        public string Type { get; set; }
        public int AvgTemp { get; set; }

        //Relationships

        [Display(Name = "Country Name")]
        public int CountryID { get; set; }
        public Country Country { get; set; }

        [Display(Name = "Climate")]
        public string Climate
        {
            get
            {
                if (AvgTemp > 25)
                {
                    return "Tropical";
                    }
                else
                {
                    return "Temperate";
                }
            }
        }
        public static ValidationResult PriceValidation(decimal Price, ValidationContext context)
        {
            if (Price == 0)
            {
                return ValidationResult.Success;
            }
            if (Price > 0)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Price should be positive");
        }

    }
}
