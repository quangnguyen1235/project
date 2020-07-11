using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN_Harpstore1.Models
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
           
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<OrderDetail>()
                .HasOne<Product>(s => s.OrderDetailProduct)
                .WithMany(g => g.ProductOrderDetails)
                .HasForeignKey(ad => ad.ProductId);
            modelBuilder.Entity<OrderDetail>()
                .HasOne<Order>(s => s.OrderDetailOrder)
                .WithMany(g => g.ListOrderDetails)
                .HasForeignKey(ad => ad.OrderDetailId);
            modelBuilder.Entity<Order>()
                .HasOne<Customer>(s => s.OrderCustomer)
                .WithOne(g => g.CustomerOrder)
                .HasForeignKey<Customer>(ad => ad.OrderId);
            modelBuilder.Entity<Customer>()
                .HasOne<Order>(s => s.CustomerOrder)
                .WithOne(g => g.OrderCustomer)
                .HasForeignKey<Order>(ad => ad.CustomerId);
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Protype> Protypes { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }

    }
}
