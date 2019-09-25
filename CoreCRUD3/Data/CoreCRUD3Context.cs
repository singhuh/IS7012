using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CoreCRUD3.Models;

namespace CoreCRUD3.Models
{
    public class CoreCRUD3Context : DbContext
    {
        internal readonly object Destinations;

        public CoreCRUD3Context (DbContextOptions<CoreCRUD3Context> options)
            : base(options)
        {
        }

        public DbSet<CoreCRUD3.Models.Country> Country { get; set; }

        public DbSet<CoreCRUD3.Models.Destination> Destination { get; set; }
    }
}
