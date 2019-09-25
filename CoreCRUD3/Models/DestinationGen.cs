using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace CoreCRUD3.Models
{
    public class DestinationGen
    {
        public class E
        {
            public E(string name, string type, double latitude, double longitude)
            {
                DName = name;
                Type = type;
                Latitude = latitude;
                Longitude = longitude;
            }
            public string DName { get; set; }
            public string Type { get; set; }
            public double Latitude { get; set; }
            public double Longitude { get; set; }
        }
        public static E[] GetArray()
        {
            return new E[]
            {
                new E("New York", "Metropolitan", 40, -90),
                new E("LA", "Metropolitan", 10, -105),
                new E("Chicago", "Metropolitan", 60, -100),
                new E("Kolkata", "Metropolitan", 50, 100),
                new E("French Polynesia", "Resort", 10, 10)
            };
        }
    }
}

