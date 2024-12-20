namespace HotelBookingService.Contracts.Bookings
{
    public record BookingRequest(
        Guid hotelId,
        DateTime Date);
}
