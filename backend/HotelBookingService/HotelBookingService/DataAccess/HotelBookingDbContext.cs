using HotelBookingService.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingService.DataAccess
{
    public class HotelBookingDbContext : DbContext 
    {
        public HotelBookingDbContext(DbContextOptions<HotelBookingDbContext> options) 
            : base(options) { }

        public DbSet<HotelEntity> Hotels { get; set; }
        public DbSet<BookingEntity> Bookings { get; set; }
    }
}
