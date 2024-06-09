<<<<<<< HEAD
using System.Diagnostics; 
using Microsoft.AspNetCore.Mvc; 
using ProjektSklep.Data; 
using ProjektSklep.Models; 

namespace ProjektSklep.Controllers; // Przestrzeñ nazw dla kontrolerów projektu.

public class HomeController : Controller // Definicja kontrolera HomeController, dziedzicz¹cego z klasy Controller.
{
    private readonly ApplicationDbContext _context; // Pole do przechowywania kontekstu bazy danych.

    public HomeController(ApplicationDbContext context) // Konstruktor kontrolera przyjmuj¹cy kontekst bazy danych jako parametr.
    {
        _context = context; // Inicjalizacja pola kontekstu bazy danych.
    }

    public void AddProductIfNotExists(Product product) // Metoda dodaj¹ca produkt do bazy, jeœli jeszcze nie istnieje.
    {
        var dbProduct = _context.Products.FirstOrDefault(p => p.Id == product.Id); // Sprawdzenie, czy produkt o danym ID istnieje w bazie.

        if (dbProduct != null) return; // Jeœli produkt istnieje, metoda koñczy dzia³anie.
        _context.Products.Add(product); // Dodanie produktu do bazy danych.
        _context.SaveChanges(); // Zapisanie zmian w bazie danych.
    }

    public IActionResult Index() // Akcja wyœwietlaj¹ca stronê g³ówn¹.
    {
        AddProductIfNotExists(new Product // Dodanie produktu do bazy, jeœli nie istnieje (Apple iPhone 15 128GB Black).
=======
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
>>>>>>> 32d131835f28a01e93bea9a17374fbda08522876
        {
            Id = 1,
            Name = "Apple iPhone 15 128GB Black",
            ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2023/9/pr_2023_9_12_22_21_55_906_00.jpg",
            Price = 3499.0,
            Count = 1
        });
<<<<<<< HEAD

        AddProductIfNotExists(new Product // Dodanie produktu do bazy, jeœli nie istnieje (Apple iPhone 15 Pro 128GB Black Titanium).
=======
        
        AddProductIfNotExists(new Product
>>>>>>> 32d131835f28a01e93bea9a17374fbda08522876
        {
            Id = 2,
            Name = "Apple iPhone 15 Pro 128GB Black Titanium",
            ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2023/9/pr_2023_9_12_22_24_25_202_00.jpg",
            OldPrice = 4499.0,
            Price = 4299.0,
            Count = 1
        });
<<<<<<< HEAD

        AddProductIfNotExists(new Product // Dodanie produktu do bazy, jeœli nie istnieje (Samsung Galaxy Z Fold5 5G 1TB).
=======
        
        AddProductIfNotExists(new Product
>>>>>>> 32d131835f28a01e93bea9a17374fbda08522876
        {
            Id = 3,
            Name = "Samsung Galaxy Z Fold5 5G 1TB",
            ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2023/7/pr_2023_7_18_10_19_37_801_01.jpg",
            Price = 9799.0,
            Count = 1
        });
<<<<<<< HEAD

        AddProductIfNotExists(new Product // Dodanie produktu do bazy, jeœli nie istnieje (Samsung Galaxy S24+ 256GB).
=======
        
        AddProductIfNotExists(new Product
>>>>>>> 32d131835f28a01e93bea9a17374fbda08522876
        {
            Id = 4,
            Name = "Samsung Galaxy S24+ 256GB",
            ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2024/1/pr_2024_1_12_8_50_47_630_02.jpg",
            Price = 4499.0,
            Count = 1
        });
<<<<<<< HEAD

        return View(_context.Products.ToList()); // Zwrócenie widoku z list¹ produktów.
    }

    public IActionResult Privacy() // Akcja wyœwietlaj¹ca stronê z polityk¹ prywatnoœci.
    {
        return View(); // Zwrócenie widoku polityki prywatnoœci.
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)] // Atrybut konfiguruj¹cy buforowanie odpowiedzi.
    public IActionResult Error() // Akcja wyœwietlaj¹ca stronê b³êdu.
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier }); // Zwrócenie widoku b³êdu z modelem zawieraj¹cym ID ¿¹dania.
    }
}
=======
        
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
>>>>>>> 32d131835f28a01e93bea9a17374fbda08522876
