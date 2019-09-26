using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreCountry.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string CName { get; set; }

        [Required]
        [StringLength(50)]
        public string Continent { get; set; }
        public bool? RequireTravelVisa { get; set; }
        public ICollection<Destination> Destinations { get; set; }

    }
}
