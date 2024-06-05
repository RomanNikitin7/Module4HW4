using ALevelSample.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ALevelSample.Data.EntityConfigurations
{
    public class BreedEntityConfiguration : IEntityTypeConfiguration<BreedEntity>
    {
        public void Configure(EntityTypeBuilder<BreedEntity> builder)
        {
            builder.HasKey(h => h.Id);
            builder.Property(p => p.BreedName).IsRequired();
            builder.Property(p => p.CategoryId).IsRequired();

            builder.HasOne(h => h.Category)
                .WithMany(w => w.CategoryBreedItems)
                .HasForeignKey(h => h.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
