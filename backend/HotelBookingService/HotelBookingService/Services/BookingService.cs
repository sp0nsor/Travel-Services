using HotelBookingService.Contracts.Bookings;
using HotelBookingService.Core.Abstractions.Repositories;
using HotelBookingService.Core.Abstractions.Services;
using HotelBookingService.Core.Models;

namespace HotelBookingService.Services
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository bookingRepository;

        public BookingService(IBookingRepository bookingRepository)
        {
            this.bookingRepository = bookingRepository;
        }

        public async Task<IResult> CreateBooking(BookingRequest request)
        {
            var (booking, error) = Booking.Create(
                Guid.NewGuid(),
                request.hotelId,
                request.Date);

            if (!string.IsNullOrEmpty(error))
            {
                return Results.BadRequest(error);
            }

            var response = await bookingRepository.Create(booking);

            return Results.Ok(response);
        }
    }
}
