namespace ProjektSklep.Models;

<<<<<<< HEAD
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
=======
public class Product
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? ImageUrl { get; set; }
    public double Price { get; set; }
    public double OldPrice { get; set; }
    public int Count { get; set; } = 1;
}
>>>>>>> 32d131835f28a01e93bea9a17374fbda08522876
