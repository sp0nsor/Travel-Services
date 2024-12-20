using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantCatalogService.DataAccess.Entities;

namespace RestaurantCatalogService.DataAccess.Configurations
{
    public class ReviewConfiguration : IEntityTypeConfiguration<ReviewEntity>
    {
        public void Configure(EntityTypeBuilder<ReviewEntity> builder)
        {
            builder.HasKey(r => r.Id);

            builder.Property(r => r.Description)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(r => r.Score)
                .IsRequired();
        }
    }
}
