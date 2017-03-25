using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace OdeToFood.Entities
{
    public class OdeToFoodDBContext : IdentityDbContext<User>
    {
        public OdeToFoodDBContext(DbContextOptions options) : base(options)
        {
           
        }

        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
