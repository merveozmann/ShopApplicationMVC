using Microsoft.EntityFrameworkCore;
using ShopApplication.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApplication.DataAccess.Concrete.EfCore
{
    public class ShopContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=ShopDb;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>()
                .HasKey(c=>new {c.CategoryId,c.ProductId });
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
