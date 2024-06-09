using System.Security.Claims; 
using Microsoft.AspNetCore.Authorization; 
using Microsoft.AspNetCore.Mvc; 
using Microsoft.EntityFrameworkCore; 
using ProjektSklep.Data;
using ProjektSklep.Models; 

namespace ProjektSklep.Controllers; // Przestrzeń nazw dla kontrolerów projektu.

public class OrdersController : Controller // Definicja kontrolera OrdersController, dziedziczącego z klasy Controller.
{
    private readonly ApplicationDbContext _context; // Pole do przechowywania kontekstu bazy danych.

    public OrdersController(ApplicationDbContext context) // Konstruktor kontrolera przyjmujący kontekst bazy danych jako parametr.
    {
        _context = context; // Inicjalizacja pola kontekstu bazy danych.
    }

    [Authorize] // Atrybut wymagający, aby użytkownik był zalogowany do wywołania tej akcji.
    public IActionResult Index() // Akcja wyświetlająca historię zamówień użytkownika.
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value; // Pobranie ID zalogowanego użytkownika.

        var carts = _context.Carts // Pobranie zamówionych koszyków użytkownika.
            .Include(c => c.Products) // Dołączenie produktów do zapytania.
            .Where(c => c.UserId == userId && c.IsOrdered) // Filtracja koszyków według użytkownika i stanu zamówienia.
            .ToList(); // Konwersja wyniku do listy.

        foreach (var cart in carts) // Iteracja po każdym koszyku użytkownika.
        {
            var products = new List<Product>(); // Utworzenie nowej listy produktów.

            foreach (var id in cart.ProductIds) // Iteracja po ID produktach w koszyku.
            {
                var product = _context.Products.FirstOrDefault(p => p.Id == id); // Pobranie produktu o danym ID.
                products.Add(product); // Dodanie produktu do listy produktów.
            }

            cart.Products = products; // Ustawienie listy produktów w koszyku.
        }

        return View(carts); // Zwrócenie widoku z listą zamówionych koszyków.
    }
}
