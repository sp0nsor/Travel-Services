namespace RestaurantCatalogService.DataAccess.Entities
{
    public class RestaurantEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string PriceCategory { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public double Rating { get; set; }
        public List<ReviewEntity> Reviews { get; set; } = [];
    }
}
