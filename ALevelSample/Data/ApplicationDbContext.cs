using ALevelSample.Data.Entities;
using ALevelSample.Data.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace ALevelSample.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<PetEntity> Pet { get; set; } = null!;
    public DbSet<CategoryEntity> Category { get; set; } = null!;
    public DbSet<BreedEntity> Breed { get; set; } = null!;
    public DbSet<LocationEntity> Location { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new PetEntityConfiguration());
        modelBuilder.ApplyConfiguration(new CategoryEntityConfiguration());
        modelBuilder.ApplyConfiguration(new BreedEntityConfiguration());
        modelBuilder.ApplyConfiguration(new LocationEntityConfiguration());
        modelBuilder.UseHiLo();
    }
}