namespace HotelBookingService.Core.Models
{
    public class Booking
    {
        private Booking(Guid id, Guid hotelId, DateTime bookingTime)
        {
            Id = id;
            HotelId = hotelId;
            BookingTime = bookingTime;
        }

        public Guid Id { get; private set; }
        public Guid HotelId { get; private set; }
        public DateTime BookingTime { get; private set; }

        public static(Booking Booking, string Error) Create(Guid id, Guid hotelId, DateTime bookingTime)
        {
            var error = string.Empty;

            if(bookingTime <  DateTime.Now)
            {
                error = "Incorrect booking time!";
            }

            var booking = new Booking(id, hotelId, bookingTime);

            return (booking, error);
        }
    }
}
