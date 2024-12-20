using HotelBookingService.Core.Models;

namespace HotelBookingService.Core.Abstractions.Repositories
{
    public interface IHotelRepository
    {
        Task<Guid> Create(Hotel hotel);
        Task<List<Hotel>> Get();
        Task<Hotel> GetById(Guid Id);
    }
}