namespace HotelBookingService.Contracts.Hotels
{
    public record HotelRequest(
        string Name,
        string Description,
        string PriceCategory,
        string City);
}
