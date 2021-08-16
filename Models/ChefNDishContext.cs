using Microsoft.EntityFrameworkCore;

namespace ChefNDish.Models
{
    public class ChefNDishContext : DbContext
    {
        public ChefNDishContext(DbContextOptions options) : base(options) { }

        public DbSet<Chef> Chefs { get; set; }
        public DbSet<Dish> Dishs { get; set; }
    }
}