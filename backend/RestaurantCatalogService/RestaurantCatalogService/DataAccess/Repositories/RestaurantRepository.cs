using Microsoft.EntityFrameworkCore;
using RestaurantCatalogService.Core.Abstractions;
using RestaurantCatalogService.Core.Models;
using RestaurantCatalogService.DataAccess.Entities;

namespace RestaurantCatalogService.DataAccess.Repositories
{
    public class RestaurantRepository : IRestaurantRepository
    {
        private readonly RestaurantCatalogDbContext context;

        public RestaurantRepository(RestaurantCatalogDbContext context)
        {
            this.context = context;
        }

        public async Task<Guid> Create(Restaurant restaurant)
        {
            var restaurantEntity = new RestaurantEntity
            {
                Id = restaurant.Id,
                Name = restaurant.Name,
                Description = restaurant.Description,
                PriceCategory = restaurant.PriceCategory,
                City = restaurant.City,
                Address = restaurant.Address,
                Rating = restaurant.Rating,
                Reviews = restaurant.Reviews
                .Select(r => new ReviewEntity
                {
                    Id = r.Id,
                    RestaurantId = restaurant.Id,
                    Description = r.Description,
                    Score = r.Score,
                }).ToList()
            };

            await context.Restaurants.AddAsync(restaurantEntity);
            await context.SaveChangesAsync();

            return restaurantEntity.Id;
        }

        public async Task<List<Restaurant>> Get(string? searchCity, string? searchCategory)
        {
            var restaurantQuery = context.Restaurants
                .Include(r => r.Reviews)
                .Where(r => !string.IsNullOrEmpty(searchCity)
                && r.City.ToLower() == searchCity.ToLower()
                && !string.IsNullOrEmpty(searchCategory)
                && r.PriceCategory.ToLower() == searchCategory.ToLower());

            restaurantQuery = restaurantQuery.OrderByDescending(r => r.Rating);

            var restaurantsEntity = restaurantQuery.ToList();

            var restaurants = restaurantsEntity
                .Select(r => Restaurant.Create(
                    r.Id,
                    r.Name,
                    r.Description,
                    r.PriceCategory,
                    r.City,
                    r.Address,
                    r.Reviews.Select(rw =>
                    Review.Create(
                        rw.Id,
                        rw.Description,
                        rw.Score).Review)
                    .ToList()).Restaurant).ToList();

            return restaurants;
        }
    }
}
