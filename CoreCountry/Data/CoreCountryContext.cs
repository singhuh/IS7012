using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CoreCountry.Models;

namespace CoreCountry.Models
{
    public class CoreCountryContext : DbContext
    {
        public CoreCountryContext (DbContextOptions<CoreCountryContext> options)
            : base(options)
        {
        }

        public DbSet<CoreCountry.Models.Country> Country { get; set; }

        public DbSet<CoreCountry.Models.Destination> Destination { get; set; }
    }
}
