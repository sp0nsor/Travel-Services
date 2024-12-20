using HotelBookingService.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelBookingService.DataAccess.Configurations
{
    public class BookingConfiguration : IEntityTypeConfiguration<BookingEntity>
    {
        public void Configure(EntityTypeBuilder<BookingEntity> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.HotelId).IsRequired();
            builder.Property(b => b.BookingTime).IsRequired();
        }
    }
}
