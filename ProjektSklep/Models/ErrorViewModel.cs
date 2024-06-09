namespace ProjektSklep.Models;

<<<<<<< HEAD
// Klasa reprezentuj¹ca model b³êdu wykorzystywany w widokach.
public class ErrorViewModel
{
    // Identyfikator ¿¹dania, który jest powi¹zany z b³êdem.
    public string? RequestId { get; set; }

    // W³aœciwoœæ okreœlaj¹ca, czy nale¿y wyœwietlaæ identyfikator ¿¹dania.
    // Zwraca true, jeœli RequestId nie jest puste lub null, w przeciwnym razie zwraca false.
    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
=======
public class ErrorViewModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
>>>>>>> 32d131835f28a01e93bea9a17374fbda08522876
