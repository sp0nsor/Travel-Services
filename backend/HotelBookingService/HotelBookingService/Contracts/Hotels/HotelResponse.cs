namespace HotelBookingService.Contracts.Hotels
{
    public record HotelResponse(
        string Name,
        string Description,
        string PriceCategory,
        string City);
}
