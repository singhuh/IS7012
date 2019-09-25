﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CoreCrud.Models
{
    public class CoreCrudContext : DbContext
    {
        public CoreCrudContext (DbContextOptions<CoreCrudContext> options)
            : base(options)
        {
        }

        public DbSet<CoreCrud.Models.Destination> Destination { get; set; }
    }
}
