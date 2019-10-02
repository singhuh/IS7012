using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using StructureMap.Pipeline;
using Microsoft.VisualStudio.Web.CodeGeneration;

namespace CoreCountry.Models
{
    public class Destination
    {
        [Required(ErrorMessage = "Destination ID is required")]
        [Range(0,1000)]
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please provide a name")]
        [StringLength(30, MinimumLength =2)]
        [Display(Name = "Destination Name")]
        public string DName { get; set; }

        [Required(ErrorMessage = "Budget must be between 500 and 1000000")]
        [Range(500, 1000000)]
        public decimal Budget { get; set; }
        
        [DataType(DataType.Date)]
        [Display(Name = "Travel Date")]
        public DateTime TravelDate { get; set; }

        [Required(ErrorMessage = "City Code must be three characters")]
        [StringLength(3)]
        [Display(Name = "City Code")]
        public string CityCode { get; set; }

        [StringLength(30, MinimumLength =2)]
        public string Type { get; set; }

        [Display(Name = "Average Temperature")]
        [Range(-60, 60)]
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
        public static ValidationResult BudgetValidation(decimal Budget, ValidationContext context)
        {
            if (Budget > 500)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Budget should be greater than 500");
        }
        public static ValidationResult BudgetValidationPositive(decimal Budget, ValidationContext context)
        {
            if (Budget > 0)
            {
                return ValidationResult.Success;
            }
            var positiveBudget = (Budget + 500);
            if (positiveBudget < Budget)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult($"Budget must be greater than {positiveBudget.ToString()}");
        }
        public static ValidationResult DNameValidation(string DName, ValidationContext context)
        {
            if (string.IsNullOrWhiteSpace(DName))
            {
                return ValidationResult.Success;
            }
           
          return new ValidationResult("City Code should not be blank");
        }

    }
}
