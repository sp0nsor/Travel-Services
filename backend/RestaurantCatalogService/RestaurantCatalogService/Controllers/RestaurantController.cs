using Microsoft.AspNetCore.Mvc;
using RestaurantCatalogService.Contracts;
using RestaurantCatalogService.Core.Abstractions;

namespace RestaurantCatalogService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RestaurantController : ControllerBase
    {
        private readonly IRestaurantService restaurantService;

        public RestaurantController(IRestaurantService restaurantService)
        {
            this.restaurantService = restaurantService;
        }

        [HttpPut]
        public async Task<List<RestaurantResponse>> GetRestaurants([FromBody] GetRestaurantRequest request)
        {
            var response = await restaurantService.GetRestaurants(request);

            return response;
        }

        [HttpPost]
        public async Task<IResult> CreateRestaurant([FromBody] CreateRestaurantRequest request)
        {
            var response = await restaurantService.CreateRestaurant(request);

            return response;
        }
    }
}
