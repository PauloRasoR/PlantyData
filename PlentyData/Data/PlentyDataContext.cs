﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PlentyData.Models;

namespace PlentyData.Data
{
    public class PlentyDataContext : DbContext
    {
        public PlentyDataContext (DbContextOptions<PlentyDataContext> options)
            : base(options)
        {
        }

        public DbSet<PlentyData.Models.Produto> Produto { get; set; } = default!;
    }
}
