using HotelBookingService.Core.Abstractions.Repositories;
using HotelBookingService.Core.Models;
using HotelBookingService.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingService.DataAccess.Repositories
{
    public class HotelRepository : IHotelRepository
    {
        private readonly HotelBookingDbContext context;

        public HotelRepository(HotelBookingDbContext context)
        {
            this.context = context;
        }

        public async Task<Guid> Create(Hotel hotel)
        {
            var hotelEntity = new HotelEntity
            {
                Id = hotel.Id,
                Name = hotel.Name,
                Description = hotel.Description,
                PriceCategory = hotel.PriceCategory,
                City = hotel.City
            };

            await context.Hotels.AddAsync(hotelEntity);
            await context.SaveChangesAsync();

            return hotelEntity.Id;
        }

        public async Task<List<Hotel>> Get()
        {
            var hotelsEnities = await context.Hotels
                .AsNoTracking()
                .ToListAsync();

            var hotels = hotelsEnities.Select(h => Hotel.Create(
                h.Id,
                h.Name,
                h.Description,
                h.PriceCategory,
                h.City).Hotel).ToList();

            return hotels;
        }

        public async Task<Hotel> GetById(Guid Id)
        {
            var hotelEntity = await context.Hotels.FirstOrDefaultAsync(h => h.Id == Id);

            var hotel = Hotel.Create(
                hotelEntity.Id,
                hotelEntity.Name,
                hotelEntity.Description,
                hotelEntity.PriceCategory,
                hotelEntity.City).Hotel;


            return hotel;
        }
    }
}
