// SeedData.cs
using System;
using System.Collections.Generic;
using System.Linq;
using szymon.Models;

namespace szymon.Data
{
    public static class SeedData
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (!context.Products.Any())
            {
                var products = new List<Product>
        {
            new Product { Name = "Garnek", Price = 55.99, Description = "" },
            new Product { Name = "Miska", Price = 12.99, Description = "" },
            new Product { Name = "Patelnia", Price = 99.99, Description = "" },
            new Product { Name = "Zestaw sztućców (30 elementów)", Price = 149.99, Description = "" },
            new Product { Name = "Zestaw szklanek (5 elementów)", Price = 45.99, Description = "" }
        };

                context.Products.AddRange(products);
                context.SaveChanges();
            }
        }

    }
}
