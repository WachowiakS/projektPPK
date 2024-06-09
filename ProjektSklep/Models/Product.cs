namespace ProjektSklep.Models;

// Klasa reprezentująca produkt w sklepie.
public class Product
{
    // Identyfikator produktu.
    public int Id { get; set; }

    // Nazwa produktu.
    public string? Name { get; set; }

    // Adres URL obrazu produktu.
    public string? ImageUrl { get; set; }

    // Cena produktu.
    public double Price { get; set; }

    // Stara cena produktu (jeśli istnieje).
    public double OldPrice { get; set; }

    // Dostępna liczba produktów.
    public int Count { get; set; } = 1;
}
