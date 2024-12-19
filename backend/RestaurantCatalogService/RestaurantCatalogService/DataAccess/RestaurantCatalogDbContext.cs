using Microsoft.EntityFrameworkCore;
using RestaurantCatalogService.DataAccess.Entities;

namespace RestaurantCatalogService.DataAccess
{
    public class RestaurantCatalogDbContext : DbContext 
    {
        public RestaurantCatalogDbContext(DbContextOptions<RestaurantCatalogDbContext> options)
            : base(options) { }

        public DbSet<RestaurantEntity> Restaurants { get; set; }
        public DbSet<ReviewEntity> Reviews { get; set; }
    }
}
