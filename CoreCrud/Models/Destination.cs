using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCrud.Models
{
    public class Destination
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int AvgTemp { get; set; }
        public string LanguageSpoken { get; set; }
        public int TotalPopulation { get; set; }
        public decimal Area { get; set; }
        public int AverageTouristRating { get; set; }
        public int CountryID { get; set; }
        public Country Country { get; set; }
    }

    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Destination> Destinations { get; set; }
    }
}

