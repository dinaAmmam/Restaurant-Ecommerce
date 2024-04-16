using Microsoft.EntityFrameworkCore;
using SoftZone_task.Models;

namespace SoftZone_task.Data
{
    public class SoftZoneDBContext:DbContext
    {
        public SoftZoneDBContext()
        {
            
        }
        public SoftZoneDBContext(DbContextOptions<SoftZoneDBContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Menu>()
                .HasOne(m => m.Restaurant)
                .WithMany()
                .HasForeignKey(m => m.RestaurantId)
                .OnDelete(DeleteBehavior.Restrict);
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Restaurant> Restaurants { get; set;}
        public DbSet<Menu> Menu { get; set; }


    }
}
