namespace RestaurantCatalogService.Core.Models
{
    public class Restaurant
    {
        private Restaurant(Guid id, string name, string description, string priceCategory,
            string city, string address, double rating, List<Review> reviews)
        {
            Id = id;
            Name = name;
            Description = description;
            PriceCategory = priceCategory;
            City = city;
            Address = address;
            Rating = rating;
            Reviews = reviews;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string PriceCategory {  get; private set; } // можно ввиде enum но в падлу как-то
        public string City { get; private set; }
        public string Address { get; private set; }
        public double Rating { get; private set; }
        public List<Review> Reviews { get; private set; }

        public const int MAX_DESCRIPTION_LENGTH = 250;

        public static(Restaurant Restaurant, string Error) Create
            (Guid id, string name, string description, string priceCategory,
            string city, string address, List<Review> reviews)
        {
            var error = string.Empty;

            if(string.IsNullOrEmpty(name) ||  string.IsNullOrEmpty(description) || description.Length > MAX_DESCRIPTION_LENGTH || string.IsNullOrEmpty(priceCategory) || 
                string.IsNullOrEmpty(city) || string.IsNullOrEmpty(address))
            {
                error = "Incorrect restaurant data!";
            }

            double rating = reviews.Average(r => r.Score);

            var restaurant = new Restaurant(id, name, description, priceCategory, city, address, rating, reviews);

            return(restaurant, error);
        }
    }
}
