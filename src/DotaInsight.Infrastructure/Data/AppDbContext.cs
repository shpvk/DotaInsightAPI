using DotaInsight.Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace DotaInsight.Infrastructure.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Hero> Heroes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.ApplyConfiguration(new HeroConfiguration());
        
        base.OnModelCreating(modelBuilder);
    }
}