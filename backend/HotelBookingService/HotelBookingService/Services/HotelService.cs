using HotelBookingService.Contracts;
using HotelBookingService.Contracts.Hotels;
using HotelBookingService.Contracts.Restaurants;
using HotelBookingService.Core.Abstractions.Repositories;
using HotelBookingService.Core.Abstractions.Services;
using HotelBookingService.Core.Models;
using Microsoft.AspNetCore.Identity;

namespace HotelBookingService.Services
{
    public class HotelService : IHotelService
    {
        private readonly IHotelRepository hotelRepository;

        public HotelService(IHotelRepository hotelRepository)
        {
            this.hotelRepository = hotelRepository;
        }

        public async Task<IResult> CreateHotel(HotelRequest request)
        {
            var (hotel, error) = Hotel.Create(
                Guid.NewGuid(),
                request.Name,
                request.Description,
                request.PriceCategory,
                request.City);

            if (!string.IsNullOrEmpty(error))
            {
                return Results.BadRequest(error);
            }

            var response = await hotelRepository.Create(hotel);

            return Results.Ok(response);
        }

        public async Task<IResult> GetHotels()
        {
            var hotels = await hotelRepository.Get();

            var hotelResponse = hotels.Select(h => new HotelResponse(
                h.Name,
                h.Description,
                h.PriceCategory,
                h.City
            )).ToList();

            return Results.Ok(hotelResponse);
        }

        public async Task<RestaurantRequest> GetHotelData(Guid Id)
        {
            var hotel = await hotelRepository.GetById(Id);

            var priceCategoty = hotel.PriceCategory;
            var city = hotel.City;

            var request = new RestaurantRequest(city, priceCategoty);

            return request;
        }
    }
}
