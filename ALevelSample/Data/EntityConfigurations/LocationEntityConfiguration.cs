using ALevelSample.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ALevelSample.Data.EntityConfigurations
{
    public class LocationEntityConfiguration : IEntityTypeConfiguration<LocationEntity>
    {
        public void Configure(EntityTypeBuilder<LocationEntity> builder)
        {
            builder.HasKey(h => h.Id);
            builder.Property(p => p.LocationName).IsRequired();
        }
    }
}
