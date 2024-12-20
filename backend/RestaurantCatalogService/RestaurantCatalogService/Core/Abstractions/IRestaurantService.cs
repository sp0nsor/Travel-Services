using RestaurantCatalogService.Contracts;

namespace RestaurantCatalogService.Core.Abstractions
{
    public interface IRestaurantService
    {
        Task<IResult> CreateRestaurant(CreateRestaurantRequest request);
        Task<List<RestaurantResponse>> GetRestaurants(GetRestaurantRequest request);
    }
}