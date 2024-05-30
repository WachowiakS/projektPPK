using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using szymon.Models;

namespace szymon.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; } = default!;
        public DbSet<OrderViewModel> OrderViewModel { get; set; } = default!;
        public DbSet<Order> Orders { get; set; }
    }
}
