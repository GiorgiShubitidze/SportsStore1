using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace SportsStore
{
    public class ProductDbContext : DbContext
    {
        public DbSet<Product> products { get; set; }
        public DbSet<ProductCategory> productCategories { get; set; }
        public DbSet<ProductPicture> productPictures { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=Test3;Trusted_Connection=True;integrated security=True;");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Random rnd = new Random();
            for (int i = 1; i <= 100; i++)
            {
                modelBuilder.Entity<Product>().HasData(
                 new Product
                 {

                     ProductId = i,
                     Name = $"Product {i}",
                     Price = 20 + i,
                     CategoryId = rnd.Next(1, 6)
                 }
                 );


                modelBuilder.Entity<ProductPicture>().HasData(
                new ProductPicture
                {
                    PictureLocation = "https://via.placeholder.com/150",
                    ProductPictureId = i,
                }
                );
            }

        }


    }
}
