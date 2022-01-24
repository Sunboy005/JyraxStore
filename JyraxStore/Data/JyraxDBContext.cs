using JyraxStore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JyraxStore.Data
{
    public class JyraxDBContext : IdentityDbContext
    {
        public JyraxDBContext(DbContextOptions<JyraxDBContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Address> Address { get; set; }

        public DbSet<ProductImage> ProductImages { get; set; }

    }
}
