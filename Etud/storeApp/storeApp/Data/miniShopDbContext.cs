using Microsoft.EntityFrameworkCore;
using storeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storeApp.Data
{
    public class miniShopDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Category>()
                        .HasMany(category => category.Products)
                        .WithOne(product => product.Category)
                        .HasForeignKey(product => product.CategoryId);

            //modelBuilder.Entity<Product>()
            //            .HasOne(p => p.Category)
            //            .WithMany(c => c.Products)
            //            .HasForeignKey(p => p.CategoryId);

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\Mssqllocaldb;Database=TrendyolDb;Integrated Security=yes");

            }

        }
    }
}
