using RestaurantCatalogService.Contracts;

namespace RestaurantCatalogService.Core.Abstractions
{
    public interface IRestaurantService
    {
        Task<IResult> CreateRestaurant(CreateRestaurantRequest request);
        Task<IResult> GetRestaurants(GetRestaurantRequest request);
    }
}