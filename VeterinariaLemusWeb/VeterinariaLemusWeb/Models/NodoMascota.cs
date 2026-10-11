namespace VeterinariaLemusWeb.Models;

// Nodo de la lista enlazada: guarda una mascota y apunta al siguiente
public class NodoMascota
{
    public Mascota Dato { get; set; }
    public NodoMascota? Siguiente { get; set; }

    public NodoMascota(Mascota dato)
    {
        Dato = dato;
        Siguiente = null;
    }
}