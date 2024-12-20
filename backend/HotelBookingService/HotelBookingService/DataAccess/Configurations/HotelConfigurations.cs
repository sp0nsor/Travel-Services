using HotelBookingService.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelBookingService.DataAccess.Configurations
{
    public class HotelConfigurations : IEntityTypeConfiguration<HotelEntity>
    {
        public void Configure(EntityTypeBuilder<HotelEntity> builder)
        {
            builder.HasKey(h => h.Id);
            builder.Property(h => h.Name).IsRequired();
            builder.Property(h => h.Description).IsRequired();
            builder.Property(h => h.PriceCategory).IsRequired();
            builder.Property(h => h.City).IsRequired();

            builder.HasMany(h => h.Bookings)
                .WithOne()
                .HasForeignKey(b => b.HotelId);
        }
    }
}
