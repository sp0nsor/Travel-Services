using HotelBookingService.Contracts.Bookings;
using HotelBookingService.Contracts.Hotels;
using HotelBookingService.Contracts.Restaurants;
using HotelBookingService.Core.Abstractions.Services;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace HotelBookingService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HotelController : ControllerBase
    {
        private readonly IHotelService hotelService;
        private readonly IBookingService bookingService;
        private readonly IRestaurantService restaurantService;

        public HotelController(IHotelService hotelService,
            IBookingService bookingService,
            IRestaurantService restaurantService)
        {
            this.hotelService = hotelService;
            this.bookingService = bookingService;
            this.restaurantService = restaurantService;
        }

        [HttpPost]
        public async Task<IResult> CreateHotel([FromBody] HotelRequest request)
        {
            var response = await hotelService.CreateHotel(request);

            return response;
        }

        [HttpPost("/booking")]
        public async Task<IResult> CreateBooking([FromBody] BookingRequest request) 
        {
            var response = await bookingService.CreateBooking(request);

            var restaurantRequest = await hotelService.GetHotelData(request.hotelId);

            var restaurantResponse = await restaurantService.GetCityRestaurants(restaurantRequest);

            return Results.Ok(restaurantResponse);
        } 

        [HttpGet]
        public async Task<IResult> GetHotels()
        {
            var response = await hotelService.GetHotels();
         
            return response;
        }
    }
}
