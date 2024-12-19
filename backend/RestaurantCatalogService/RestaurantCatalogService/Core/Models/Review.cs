namespace RestaurantCatalogService.Core.Models
{
    public class Review
    {
        private Review(Guid id, string description, int score)
        {
            Id = id;
            Description = description;
            Score = score;
        }

        public Guid Id { get; private set; }
        public string Description { get; private set; }
        public int Score { get; private set; }

        public const int MAX_SCORE = 5;

        public static(Review Review, string Error) Create(Guid id, string description, int score)
        {
            var error = string.Empty;

            if(description.Length > Restaurant.MAX_DESCRIPTION_LENGTH
                || string.IsNullOrEmpty(description)
                || score < 0 || score > MAX_SCORE)
            {
                error = "Incorrect review data!";
            }

            var review = new Review(id, description, score);

            return (review, error);
        }
    }
}
