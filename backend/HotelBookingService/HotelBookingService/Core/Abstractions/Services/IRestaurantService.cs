using HotelBookingService.Contracts.Restaurants;

namespace HotelBookingService.Core.Abstractions.Services
{
    public interface IRestaurantService
    {
        Task<List<RestaurantResponse>> GetCityRestaurants(RestaurantRequest request);
    }
}