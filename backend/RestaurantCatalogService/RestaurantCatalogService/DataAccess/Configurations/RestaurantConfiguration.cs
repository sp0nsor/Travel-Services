using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantCatalogService.DataAccess.Entities;

namespace RestaurantCatalogService.DataAccess.Configurations
{
    public class RestaurantConfiguration : IEntityTypeConfiguration<RestaurantEntity>
    {
        public void Configure(EntityTypeBuilder<RestaurantEntity> builder)
        {
            builder.HasKey(r => r.Id);

            builder.Property(r => r.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(r => r.Description)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(r => r.PriceCategory)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(r => r.City)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(r => r.Address)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(r => r.Rating)
                .IsRequired()
                .HasColumnType("float");

            builder.HasMany(r => r.Reviews)
                .WithOne()
                .HasForeignKey(rw => rw.RestaurantId);
        }
    }
}
