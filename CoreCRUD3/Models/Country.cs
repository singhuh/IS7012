using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCRUD3.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Continent { get; set; }
        public bool RequiresVisa { get; set; }
        public ICollection<Destination> Destinations { get; set; }

        // READ ONLY PROPERTIES

        [NotMapped]
        public string DisplayName
        {
            // CONCATENATE THE FIRST AND LAST NAME
            // INTO A DISPLAY NAME
            get { return $"{Name}"; }
        }

        [NotMapped]
        public string DisplayContinent
        {
            // CONCATENATE THE FIRST AND LAST NAME
            // INTO A DISPLAY NAME
            get { return $"{Continent}"; }
        }

    }
}
