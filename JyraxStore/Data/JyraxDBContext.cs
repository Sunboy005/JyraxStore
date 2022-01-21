using JyraxStore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace JyraxStore.Data
{
    public class JyraxDBContext:IdentityDbContext
    {
        public JyraxDBContext(DbContextOptions<JyraxDBContext> options):base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }

    }
}
