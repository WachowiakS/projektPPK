namespace ProjektSklep.Models;

<<<<<<< HEAD
// Klasa reprezentuj�ca model b��du wykorzystywany w widokach.
public class ErrorViewModel
{
    // Identyfikator ��dania, kt�ry jest powi�zany z b��dem.
    public string? RequestId { get; set; }

    // W�a�ciwo�� okre�laj�ca, czy nale�y wy�wietla� identyfikator ��dania.
    // Zwraca true, je�li RequestId nie jest puste lub null, w przeciwnym razie zwraca false.
    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
=======
public class ErrorViewModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
>>>>>>> 32d131835f28a01e93bea9a17374fbda08522876
