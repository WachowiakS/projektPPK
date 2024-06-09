namespace ProjektSklep.Models;

// Klasa reprezentująca koszyk zakupowy w aplikacji.
public class Cart
{
    // Identyfikator koszyka.
    public int Id { get; set; }

    // Lista produktów znajdujących się w koszyku.
    public List<Product>? Products { get; set; } = new List<Product>();

    // Lista identyfikatorów produktów znajdujących się w koszyku.
    public List<int> ProductIds { get; set; } = new List<int>();

    // Identyfikator użytkownika, do którego przypisany jest koszyk.
    // Może być null, jeśli koszyk nie jest przypisany do konkretnego użytkownika.
    public string? UserId { get; set; }

    // Określa, czy koszyk został już zamówiony. Domyślnie ustawione na false.
    public bool IsOrdered { get; set; } = false;

    // Suma cen wszystkich produktów znajdujących się w koszyku.
    public double Sum { get; set; }
}
