using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN_Harpstore.Models
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    //modelBuilder.Entity<OrderDetail>()
        //    //    .HasOne<Product>(s => s.OrderDetailProduct)
        //    //    .WithMany(g => g.ProductOrderDetails)
        //    //    .HasForeignKey(ad => ad.ProductId);
        //    //modelBuilder.Entity<OrderDetail>()
        //    //    .HasOne<Order>(s => s.OrderDetailOrder)
        //    //    .WithMany(g => g.ListOrderDetails)
        //    //    .HasForeignKey(ad => ad.OrderDetailId);
        //    //modelBuilder.Entity<Order>()
        //    //    .HasOne<Customer>(s => s.OrderCustomer)
        //    //    .WithOne(g => g.CustomerOrder)
        //    //    .HasForeignKey<Customer>(ad => ad.OrderId);
        //    //modelBuilder.Entity<Customer>()
        //    //   .HasOne<Order>(s => s.CustomerOrder)
        //    //   .WithOne(g => g.OrderCustomer)
        //    //   .HasForeignKey<Order>(ad => ad.CustomerId);
        //    //modelBuilder.Entity<Product>()
        //    //    .HasOne<ProductType>(pt => pt._ProductType)
        //    //    .WithMany(g => g.ListProducts)
        //    //    .HasForeignKey(ad => ad.ProductTypeId);
        //    //modelBuilder.Entity<Product>()
        //    //   .HasOne<Producer>(pt => pt.ProductProducer)
        //    //   .WithMany(g => g.ListProducts)
        //    //   .HasForeignKey(ad => ad.ProducerId);
        ////    modelBuilder.Entity<Product>().HasData(
        ////   new Product()
        ////   {
        ////       ProductId = "093e6579-89d7-4c91-a1f6-009d5cca3776",
        ////       ProductName = "Kèn Harmonica Chromatic Suzuki G48 METAL",
        ////       FullDescription = "Cây kèn chromatic đầu bảng của Suzuki, thổi cực nhẹ, âm thanh vượt trội so với các loại chromatic khác",
        ////       ProductAvatar = "ken-harmonica-chromatic-suzuki-maret-g48.jpg",
        ////       ProductTypeId = 2,
        ////       ProducerId = 1,
        ////       IsUsed = false,
        ////       ProductPrice = 11500000
        ////   },
        ////   new Product()
        ////   {
        ////       ProductId = "093e6579-89d7-4c91-a1f6-009d5cca3786",
        ////       ProductName = "Kèn Harmonica Chromatic King Dream Easttop",
        ////       FullDescription = "Cây kèn chromatic đầu bảng của Easttop, thổi cực nhẹ, âm thanh vượt trội so với các loại chromatic khác",
        ////       ProductAvatar = "ken-harmonica-chromatic-easttop-king-dream-2.jpg",
        ////       ProductTypeId = 2,
        ////       ProducerId = 0,
        ////       IsUsed = false,
        ////       ProductPrice = 1500000
        ////   }
        ////);
        ////    modelBuilder.Entity<ProductType>().HasData(
        ////         new ProductType()
        ////         {
        ////             ProductTypeId = 0,
        ////             ProductTypeName = "Diatonic"
        ////         },
        ////         new ProductType()
        ////         {
        ////             ProductTypeId = 1,
        ////             ProductTypeName = "Tremolo"
        ////         },
        ////         new ProductType()
        ////         {
        ////             ProductTypeId = 2,
        ////             ProductTypeName = "Chromatic"
        ////         },
        ////         new ProductType()
        ////         {
        ////             ProductTypeId = 3,
        ////             ProductTypeName = "Ukelele"
        ////         }
        ////    );
        ////    modelBuilder.Entity<Producer>().HasData(
        ////         new ProductType()
        ////         {
        ////             ProductTypeId = 0,
        ////             ProductTypeName = "Easttop"
        ////         },
        ////         new ProductType()
        ////         {
        ////             ProductTypeId = 1,
        ////             ProductTypeName = "Suzuki"
        ////         },
        ////         new ProductType()
        ////         {
        ////             ProductTypeId = 2,
        ////             ProductTypeName = "Tombo"
        ////         },
        ////         new ProductType()
        ////         {
        ////             ProductTypeId = 3,
        ////             ProductTypeName = "Hohner"
        ////         },
        ////         new ProductType()
        ////         {
        ////             ProductTypeId = 4,
        ////             ProductTypeName = "Seydel"
        ////         }
        ////    );
        //}
        //public DbSet<Product> Products { get; set; }
        ////public DbSet<ProductType> ProductTypes { get; set; }
        ////public DbSet<Producer> Producers { get; set; }
        ////public DbSet<OrderDetail> OrderDetails { get; set; }
        ////public DbSet<Order> Orders { get; set; }
        ////public DbSet<Customer> Customers { get; set; }
    }
}
