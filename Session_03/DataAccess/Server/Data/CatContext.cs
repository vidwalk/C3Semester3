using Microsoft.EntityFrameworkCore;
namespace Server.Entities{
            public class CatContext : DbContext {
            public CatContext (DbContextOptions<CatContext> options) : base (options) { }
            public DbSet<Cat> cats { get; set; }
            public DbSet<Order> orders { get; set; }
        }
    }
