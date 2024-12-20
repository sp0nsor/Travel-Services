using HotelBookingService.Contracts.Hotels;
using HotelBookingService.Contracts.Restaurants;
using HotelBookingService.Core.Models;

namespace HotelBookingService.Core.Abstractions.Services
{
    public interface IHotelService
    {
        Task<IResult> CreateHotel(HotelRequest request);
        Task<IResult> GetHotels();
        Task<RestaurantRequest> GetHotelData(Guid Id);
    }
}