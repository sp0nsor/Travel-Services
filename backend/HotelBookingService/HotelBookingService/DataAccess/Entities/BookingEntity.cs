namespace HotelBookingService.DataAccess.Entities
{
    public class BookingEntity
    {
        public Guid Id { get; set; }
        public Guid HotelId { get; set; }
        public DateTime BookingTime { get; set; }
    }
}
