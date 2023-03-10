using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using test.Models;

namespace test.Data
{
    public class testContext : DbContext
    {
        public testContext (DbContextOptions<testContext> options)
            : base(options)
        {
        }

        public DbSet<test.Models.Produit> Produit { get; set; } = default!;

        public DbSet<test.Models.Panier> Panier { get; set; }

        public DbSet<test.Models.LignePanier> LignePanier { get; set; }
    }
}
