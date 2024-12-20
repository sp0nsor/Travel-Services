using HotelBookingService.Contracts.Restaurants;
using HotelBookingService.Core.Abstractions.Services;
using Microsoft.AspNetCore.Http.HttpResults;

namespace HotelBookingService.Services
{
    public class RestaurantService : IRestaurantService
    {
        private readonly HttpClient httpClient;

        public RestaurantService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<List<RestaurantResponse>> GetCityRestaurants(RestaurantRequest request)
        {
            var response = await httpClient.PutAsJsonAsync("api/Restaurant", request);

            if(response.IsSuccessStatusCode)
            {
                var restaurants = await response.Content.ReadFromJsonAsync<List<RestaurantResponse>>();

                return restaurants;
            }

            return new List<RestaurantResponse>();
        }
    }
}
