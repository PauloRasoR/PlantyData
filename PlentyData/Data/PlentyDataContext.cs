using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using PlentyData.Models;

namespace PlentyData.Data
{
    public class PlentyDataContext : DbContext
    {
        public PlentyDataContext(DbContextOptions<PlentyDataContext> options) : base(options)
        {
        }

        public DbSet<Produto> Produto{ get; set; }
        public DbSet<Unidade> Unidade { get; set; }
        public DbSet<Empresa> Empresa { get; set; }

    }
}
