using RestaurantCatalogService.Core.Models;

namespace RestaurantCatalogService.Core.Abstractions
{
    public interface IRestaurantRepository
    {
        Task<Guid> Create(Restaurant restaurant);
        Task<List<Restaurant>> Get(string? searchCity, string? searchCategory);
    }
}