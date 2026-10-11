using System.Collections;

namespace VeterinariaLemusWeb.Models;

// Lista enlazada propia para almacenar las mascotas
public class ListaMascotas : IEnumerable<Mascota>
{
    private NodoMascota? cabeza;
    private int count;

    public int Count
    {
        get { return count; }
    }

    // Registrar: agrega la mascota al final de la lista
    public void Agregar(Mascota mascota)
    {
        NodoMascota nuevo = new NodoMascota(mascota);

        if (cabeza == null)
        {
            cabeza = nuevo;
        }
        else
        {
            NodoMascota actual = cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevo;
        }
        count++;
    }

    // Buscar: devuelve la mascota con ese código, o null si no existe
    public Mascota? BuscarPorCodigo(string codigo)
    {
        NodoMascota? actual = cabeza;
        while (actual != null)
        {
            if (actual.Dato.Codigo == codigo)
            {
                return actual.Dato;
            }
            actual = actual.Siguiente;
        }
        return null;
    }

    // Eliminar: quita la mascota con ese código. Devuelve true si la eliminó
    public bool Eliminar(string codigo)
    {
        if (cabeza == null)
        {
            return false;
        }

        // Caso 1: es la primera de la lista
        if (cabeza.Dato.Codigo == codigo)
        {
            cabeza = cabeza.Siguiente;
            count--;
            return true;
        }

        // Caso 2: está en medio o al final
        NodoMascota anterior = cabeza;
        NodoMascota? actual = cabeza.Siguiente;
        while (actual != null)
        {
            if (actual.Dato.Codigo == codigo)
            {
                anterior.Siguiente = actual.Siguiente;
                count--;
                return true;
            }
            anterior = actual;
            actual = actual.Siguiente;
        }
        return false;
    }

    // Permite recorrer la lista con foreach (en las vistas)
    public IEnumerator<Mascota> GetEnumerator()
    {
        NodoMascota? actual = cabeza;
        while (actual != null)
        {
            yield return actual.Dato;
            actual = actual.Siguiente;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}