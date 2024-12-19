namespace RestaurantCatalogService.Contracts
{
    public record GetRestaurantRequest(
        string? SearchCity,
        string? SearchPricecategory);
}
