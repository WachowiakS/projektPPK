using System.Security.Claims; 
using Microsoft.AspNetCore.Authorization; 
using Microsoft.AspNetCore.Mvc; 
using Microsoft.EntityFrameworkCore; 
using ProjektSklep.Data; 
using ProjektSklep.Models; 

namespace ProjektSklep.Controllers; // Przestrzeń nazw dla kontrolerów projektu.

public class CartController : Controller // Definicja kontrolera CartController, dziedziczącego z klasy Controller.
{
    private readonly ApplicationDbContext _context; // Pole do przechowywania kontekstu bazy danych.

    public CartController(ApplicationDbContext context) // Konstruktor kontrolera przyjmujący kontekst bazy danych jako parametr.
    {
        _context = context; // Inicjalizacja pola kontekstu bazy danych.
    }

    [Authorize] // Atrybut wymagający, aby użytkownik był zalogowany do wywołania tej akcji.
    public IActionResult Index() // Akcja wyświetlająca zawartość koszyka.
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value; // Pobranie ID zalogowanego użytkownika.

        var cart = _context.Carts.Include(c => c.Products).FirstOrDefault(c => c.UserId == userId && c.IsOrdered == false); // Pobranie koszyka użytkownika, który nie został jeszcze zamówiony.
        if (cart == null) // Jeśli koszyk nie istnieje, tworzenie nowego koszyka.
        {
            cart = new Cart
            {
                UserId = userId // Ustawienie ID użytkownika w nowym koszyku.
            };
            _context.Carts.Add(cart); // Dodanie nowego koszyka do bazy danych.
        }

        // cart.Products = cart.Products.Distinct().ToList(); // (Zakomentowane) Usunięcie duplikatów produktów w koszyku.

        return View(cart); // Zwrócenie widoku koszyka.
    }

    [Authorize] // Atrybut wymagający, aby użytkownik był zalogowany do wywołania tej akcji.
    public IActionResult Add(int id) // Akcja dodająca produkt do koszyka.
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value; // Pobranie ID zalogowanego użytkownika.

        var cart = _context.Carts.Include(c => c.Products).FirstOrDefault(c => c.UserId == userId && c.IsOrdered == false); // Pobranie koszyka użytkownika, który nie został jeszcze zamówiony.
        if (cart == null) // Jeśli koszyk nie istnieje, tworzenie nowego koszyka.
        {
            cart = new Cart
            {
                UserId = userId // Ustawienie ID użytkownika w nowym koszyku.
            };
            _context.Carts.Add(cart); // Dodanie nowego koszyka do bazy danych.
        }

        var product = _context.Products.FirstOrDefault(p => p.Id == id); // Pobranie produktu o danym ID.
        if (product.Count == 0) product.Count = 1; // Jeśli produkt nie ma ustawionej ilości, ustawienie jej na 1.

        var index = cart.Products.FindIndex(p => p.Equals(product)); // Sprawdzenie, czy produkt już istnieje w koszyku.

        if (index != -1) // Jeśli produkt już istnieje w koszyku, zwiększenie jego ilości.
        {
            cart.Products[index].Count++;
        }
        else // Jeśli produkt nie istnieje w koszyku, dodanie go do listy produktów w koszyku.
        {
            cart.Products.Add(product);
        }

        // cart.Products = cart.Products.Distinct().ToList(); // (Zakomentowane) Usunięcie duplikatów produktów w koszyku.

        cart.Sum += product.Price; // Dodanie ceny produktu do sumy koszyka.

        cart.ProductIds.Add(product.Id); // Dodanie ID produktu do listy ID produktów w koszyku.

        _context.SaveChanges(); // Zapisanie zmian w bazie danych.

        return View("Index", cart); // Zwrócenie widoku koszyka.
    }

    [Authorize] // Atrybut wymagający, aby użytkownik był zalogowany do wywołania tej akcji.
    public IActionResult Remove(int id) // Akcja usuwająca produkt z koszyka.
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value; // Pobranie ID zalogowanego użytkownika.

        var cart = _context.Carts.Include(c => c.Products).FirstOrDefault(c => c.UserId == userId && c.IsOrdered == false); // Pobranie koszyka użytkownika, który nie został jeszcze zamówiony.
        if (cart == null) // Jeśli koszyk nie istnieje, tworzenie nowego koszyka.
        {
            cart = new Cart
            {
                UserId = userId // Ustawienie ID użytkownika w nowym koszyku.
            };
            _context.Carts.Add(cart); // Dodanie nowego koszyka do bazy danych.
        }

        var product = _context.Products.FirstOrDefault(p => p.Id == id); // Pobranie produktu o danym ID.

        var index = cart.Products.FindIndex(p => p.Equals(product)); // Sprawdzenie, czy produkt istnieje w koszyku.

        if (index != -1) // Jeśli produkt istnieje w koszyku, zmniejszenie jego ilości.
        {
            cart.Products[index].Count--;
        }

        if (cart.Products[index].Count == 0) // Jeśli ilość produktu wynosi 0, usunięcie go z koszyka.
        {
            cart.Products.RemoveAt(index);
        }

        // cart.Products = cart.Products.Distinct().ToList(); // (Zakomentowane) Usunięcie duplikatów produktów w koszyku.

        cart.Sum -= product.Price; // Odjęcie ceny produktu od sumy koszyka.

        cart.ProductIds.Remove(product.Id); // Usunięcie ID produktu z listy ID produktów w koszyku.

        _context.SaveChanges(); // Zapisanie zmian w bazie danych.

        return View("Index", cart); // Zwrócenie widoku koszyka.
    }

    [Authorize] // Atrybut wymagający, aby użytkownik był zalogowany do wywołania tej akcji.
    public IActionResult Order() // Akcja zamawiająca produkty w koszyku.
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value; // Pobranie ID zalogowanego użytkownika.

        var cart = _context.Carts.Include(c => c.Products).FirstOrDefault(c => c.UserId == userId && c.IsOrdered == false); // Pobranie koszyka użytkownika, który nie został jeszcze zamówiony.
        if (cart == null) // Jeśli koszyk nie istnieje, tworzenie nowego koszyka.
        {
            cart = new Cart
            {
                UserId = userId // Ustawienie ID użytkownika w nowym koszyku.
            };
            _context.Carts.Add(cart); // Dodanie nowego koszyka do bazy danych.
        }

        var products = new List<Product>(); // Utworzenie nowej listy produktów.

        foreach (var id in cart.ProductIds) // Iteracja po ID produktach w koszyku.
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id); // Pobranie produktu o danym ID.
            products.Add(product); // Dodanie produktu do listy produktów.
        }

        cart.Products = products; // Ustawienie listy produktów w koszyku.

        foreach (var product in cart.Products) // Iteracja po produktach w koszyku.
        {
            product.Count = 0; // Ustawienie ilości każdego produktu na 0.
        }

        cart.IsOrdered = true; // Ustawienie flagi zamówienia na prawdziwe.
        // cart.Products = cart.Products.Distinct().ToList(); // (Zakomentowane) Usunięcie duplikatów produktów w koszyku.

        _context.SaveChanges(); // Zapisanie zmian w bazie danych.

        return View("Success", cart); // Zwrócenie widoku sukcesu zamówienia.
    }
}
