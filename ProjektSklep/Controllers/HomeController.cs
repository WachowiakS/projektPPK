using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProjektSklep.Data;
using ProjektSklep.Models;

namespace ProjektSklep.Controllers;

public class HomeController : Controller
{
    private readonly ApplicationDbContext _context;

    public HomeController(ApplicationDbContext context)
    {
        _context = context;
    }

    public void AddProductIfNotExists(Product product)
    {
        var dbProduct = _context.Products.FirstOrDefault(p => p.Id == product.Id);

        if (dbProduct != null) return;
        _context.Products.Add(product);
        _context.SaveChanges();
    }

    public IActionResult Index()
    {
        AddProductIfNotExists(new Product
        {
            Id = 1,
            Name = "Apple iPhone 15 128GB Black",
            ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2023/9/pr_2023_9_12_22_21_55_906_00.jpg",
            Price = 3499.0,
            Count = 1
        });
        
        AddProductIfNotExists(new Product
        {
            Id = 2,
            Name = "Apple iPhone 15 Pro 128GB Black Titanium",
            ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2023/9/pr_2023_9_12_22_24_25_202_00.jpg",
            OldPrice = 4499.0,
            Price = 4299.0,
            Count = 1
        });
        
        AddProductIfNotExists(new Product
        {
            Id = 3,
            Name = "Samsung Galaxy Z Fold5 5G 1TB",
            ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2023/7/pr_2023_7_18_10_19_37_801_01.jpg",
            Price = 9799.0,
            Count = 1
        });
        
        AddProductIfNotExists(new Product
        {
            Id = 4,
            Name = "Samsung Galaxy S24+ 256GB",
            ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2024/1/pr_2024_1_12_8_50_47_630_02.jpg",
            Price = 4499.0,
            Count = 1
        });
        
        return View(_context.Products.ToList());
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}