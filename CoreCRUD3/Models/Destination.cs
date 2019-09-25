using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCRUD3.Models
{
    public class Destination
    {
        [Key]
        public int Id { get; set; }
        public string DName { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public bool HasBeach { get; set; }
        public string Type { get; set; }
        public bool HasAirport { get; set; }
        public int AvgCostPerDay { get; set; }
        public bool Has5StarHotel { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
     }
}
