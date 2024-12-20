namespace HotelBookingService.Core.Models
{
    public class Hotel
    {
        private Hotel(Guid id, string name, string description, string priceCategory, string city)
        {
            Id = id;
            Name = name;
            Description = description;
            PriceCategory = priceCategory;
            City = city;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string PriceCategory { get; private set; }
        public string City { get; private set; }

        public static(Hotel Hotel, string Error) Create
            (Guid id, string name, string description,
            string priceCategory, string city)
        {
            var error = string.Empty;

            if(string.IsNullOrEmpty(name) || string.IsNullOrEmpty(description)
                || string.IsNullOrEmpty(priceCategory) || string.IsNullOrEmpty(city))
            {
                error = "Incorrect hotel data!";
            }

            var hotel = new Hotel(id, name, description, priceCategory, city);

            return (hotel, error);
        }
    }
}
