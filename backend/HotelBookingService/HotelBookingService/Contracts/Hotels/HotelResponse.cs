namespace HotelBookingService.Contracts.Hotels
{
    public record HotelResponse(
        Guid Id,
        string Name,
        string Description,
        string PriceCategory,
        string City);
}
