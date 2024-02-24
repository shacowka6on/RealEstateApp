using Microsoft.EntityFrameworkCore;
using RealEstateApp.Infrastructure.Data.Models;
using Property = RealEstateApp.Infrastructure.Data.Models.Property;

namespace RealEstateApp.Infrastructure
{
    public class RealEstateDbContext : DbContext
    {
        public RealEstateDbContext(DbContextOptions<RealEstateDbContext> options)
            : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Address> Addresses { get; set; } = null!;
        public DbSet<Post> Posts { get; set; } = null!;
        public DbSet<Property> Properties { get; set; } = null!;
        public DbSet<Review> Reviews { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
    }
}
