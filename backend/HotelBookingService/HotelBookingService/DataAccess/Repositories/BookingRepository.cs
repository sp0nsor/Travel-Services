using HotelBookingService.Core.Abstractions.Repositories;
using HotelBookingService.Core.Models;
using HotelBookingService.DataAccess.Entities;

namespace HotelBookingService.DataAccess.Repositories
{
    public class BookingRepository : IBookingRepository
    {
        private readonly HotelBookingDbContext context;

        public BookingRepository(HotelBookingDbContext context)
        {
            this.context = context;
        }

        public async Task<Guid> Create(Booking booking)
        {
            var bookingEntity = new BookingEntity
            {
                Id = booking.Id,
                HotelId = booking.HotelId,
                BookingTime = booking.BookingTime,
            };

            await context.Bookings.AddAsync(bookingEntity);
            await context.SaveChangesAsync();

            return bookingEntity.Id;
        }
    }
}
