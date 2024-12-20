namespace HotelBookingService.DataAccess.Entities
{
    public class HotelEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string PriceCategory { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public List<BookingEntity> Bookings { get; set; } = [];
    }
}
