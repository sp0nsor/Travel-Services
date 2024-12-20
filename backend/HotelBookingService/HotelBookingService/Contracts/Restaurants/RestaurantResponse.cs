namespace HotelBookingService.Contracts.Restaurants
{
    public record RestaurantResponse(
        string Name,
        string Description,
        string PriceCategory,
        string City,
        string Address,
        double Rating);
}
