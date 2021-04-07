using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Inventory.API.Models;

namespace Inventory.API.Data
{
    public class InventoryContext:DbContext
    {
        public InventoryContext(DbContextOptions<InventoryContext> options):base(options)
        {
            
        }
        
        public DbSet<Models.Inventory> Inventory { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Inventory>()
                .HasIndex(x => x.SKU)
                .IsUnique();
        }
    }
}
