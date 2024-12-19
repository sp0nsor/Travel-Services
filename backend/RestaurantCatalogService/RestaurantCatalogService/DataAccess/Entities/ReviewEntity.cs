namespace RestaurantCatalogService.DataAccess.Entities
{
    public class ReviewEntity
    {
        public Guid Id { get; set; }
        public Guid RestaurantId { get; set; }
        public string Description { get; set; } = string.Empty;
        public int Score { get; set; }

    }
}
