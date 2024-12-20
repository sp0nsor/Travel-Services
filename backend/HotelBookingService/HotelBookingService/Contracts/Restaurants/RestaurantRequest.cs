namespace HotelBookingService.Contracts.Restaurants
{
    public record RestaurantRequest(
        string? SearchCity,
        string? SearchPricecategory);
}
