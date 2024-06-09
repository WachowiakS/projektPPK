namespace ProjektSklep.Models;

<<<<<<< HEAD
<<<<<<< HEAD
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
=======
=======
>>>>>>> 32d131835f28a01e93bea9a17374fbda08522876
public class Cart
{
    public int Id { get; set; }
    public List<Product>? Products { get; set; } = new List<Product>();
    public List<int> ProductIds { get; set; } = new List<int>();
    public string? UserId { get; set; }
    public bool IsOrdered { get; set; } = false;
    public double Sum { get; set; }
<<<<<<< HEAD
}
>>>>>>> 32d131835f28a01e93bea9a17374fbda08522876
=======
}
>>>>>>> 32d131835f28a01e93bea9a17374fbda08522876
