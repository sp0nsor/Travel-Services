namespace RestaurantCatalogService.Contracts
{
    public record CreateReviewRequest(
        string Discription, 
        int Score);
}
