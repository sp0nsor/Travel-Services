using HotelBookingService.Contracts.Bookings;

namespace HotelBookingService.Core.Abstractions.Services
{
    public interface IBookingService
    {
        Task<IResult> CreateBooking(BookingRequest request);
    }
}