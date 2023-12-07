using HoliProp.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace HoliProp.Data.Contexts;

public class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseInMemoryDatabase(databaseName: "HoliPropDB");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Property>().HasKey(p => p.Id);
    }

    public DbSet<Property> Properties { get; set; }
    public DbSet<ImageAddress> ImageAdderesses { get; set; }
    public DbSet<Booking> Bookings { get; set; }
}
