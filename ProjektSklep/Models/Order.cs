namespace ProjektSklep.Models;

// Klasa reprezentująca zamówienia w systemie.
public class Orders
{
    // Identyfikator zamówienia.
    public int Id { get; set; }

    // Lista koszyków, które są częścią tego zamówienia.
    public List<Cart> Carts { get; set; } = new List<Cart>();

    // Identyfikator użytkownika, który złożył zamówienie.
    public string? UserId { get; set; }
}
