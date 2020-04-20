using Microsoft.EntityFrameworkCore;

namespace ChefDish.Models {
    public class MyContext : DbContext {
        public MyContext (DbContextOptions options) : base (options) { }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<CatChef> CatChefs { get; set; }
    }
}