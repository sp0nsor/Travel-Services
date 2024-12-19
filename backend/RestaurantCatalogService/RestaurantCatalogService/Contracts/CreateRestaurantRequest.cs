namespace RestaurantCatalogService.Contracts
{
    public record CreateRestaurantRequest(
        string Name,
        string Description,
        string PriceCategory,
        string City,
        string Address,
        List<CreateReviewRequest> Reviews);
}
