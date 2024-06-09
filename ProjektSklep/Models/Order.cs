namespace ProjektSklep.Models;

<<<<<<< HEAD
<<<<<<< HEAD
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
=======
=======
>>>>>>> 32d131835f28a01e93bea9a17374fbda08522876
public class Orders
{
    public int Id { get; set; }
    public List<Cart> Carts { get; set; } = new List<Cart>();
    public string? UserId { get; set; }
<<<<<<< HEAD
}
>>>>>>> 32d131835f28a01e93bea9a17374fbda08522876
=======
}
>>>>>>> 32d131835f28a01e93bea9a17374fbda08522876
