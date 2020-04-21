using Microsoft.EntityFrameworkCore;

namespace ChefDish.Models {
    public class MyContext : DbContext {
        public MyContext (DbContextOptions options) : base (options) { }
        public DbSet<Dish> LosPlatos { get; set; }
        public DbSet<CatChef> LosGatos { get; set; }
    }
}