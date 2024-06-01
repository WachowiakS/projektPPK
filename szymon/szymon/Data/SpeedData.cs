using System.Collections.Generic;
using System.Linq;
using szymon.Models;

namespace szymon.Data
{
    public static class SeedData
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (context.Products.Any())
            {
                context.Products.RemoveRange(context.Products);
                context.SaveChanges();
            }

            var newProducts = new List<Product>
            {
                new Product { Name = "Klawiatura", Price = 255.99, Description = "Mechaniczna" },
                new Product { Name = "Myszka", Price = 212.99, Description = "Bezprzewodowa" },
                new Product { Name = "Monitor", Price = 599.99, Description = "144HZ" },
                new Product { Name = "Zestaw przycisków", Price = 49.99, Description = "" },
                new Product { Name = "Podkładka pod mysz", Price = 45.99, Description = "Duża" }
            };

            context.Products.AddRange(newProducts);
            context.SaveChanges();
        }
    }
}
