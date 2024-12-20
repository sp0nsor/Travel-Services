using HotelBookingService.Core.Models;

namespace HotelBookingService.Core.Abstractions.Repositories
{
    public interface IBookingRepository
    {
        Task<Guid> Create(Booking booking);
    }
}