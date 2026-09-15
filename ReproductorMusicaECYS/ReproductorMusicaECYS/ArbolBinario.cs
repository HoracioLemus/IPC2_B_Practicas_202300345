namespace ReproductorMusicaECYS;
using System;
public class ArbolBinario
{
    private NodoArbol raiz;

    public ArbolBinario()
    {
        raiz = null;
    }
    
    //Metodo principal
    public void Insertar(Cancion cancion)
    {
        raiz = InsertarRecursivo(raiz, cancion);
    }
    
    //Logica recursiva interna
    private NodoArbol InsertarRecursivo(NodoArbol nodo, Cancion cancion)
    {
        //Si hay vacio se hace un nuevo nodo
        if (nodo==null)
        {
            return new NodoArbol(cancion);
        }
        
        //Comprobaciones
        int comprobacion = string.Compare(cancion.Titulo, nodo.Cancion.Titulo, StringComparison.OrdinalIgnoreCase);

        if (comprobacion <0)
        {
            nodo.Izquierdo = InsertarRecursivo(nodo.Izquierdo, cancion);
        }
        else if (comprobacion > 0)
        {
            nodo.Derecho = InsertarRecursivo(nodo.Derecho, cancion);
        }

        return nodo;

    }
    public void MostrarEnOrden()
    {
        Console.WriteLine("\n--- Árbol Binario (Orden Alfabético por Título) ---");
        MostrarEnOrdenRecursivo(raiz);
        Console.WriteLine("---------------------------------------------------\n");
    }

    private void MostrarEnOrdenRecursivo(NodoArbol nodo)
    {
        if (nodo != null)
        {
            MostrarEnOrdenRecursivo(nodo.Izquierdo);
            Console.WriteLine($"> {nodo.Cancion.Titulo} - {nodo.Cancion.Artista}");
            MostrarEnOrdenRecursivo(nodo.Derecho);
        }
    }

    public Cancion Buscar(string titulo)
    {
        return BuscarRecursivo(raiz, titulo);
    }
    
    //metodo privado que busca recursivamente
    private Cancion BuscarRecursivo(NodoArbol nodo, string titulo)
    {
        if (nodo == null)
        {
            return null;
        }

        int comparacion = string.Compare(titulo, nodo.Cancion.Titulo, StringComparison.OrdinalIgnoreCase);


        if (comparacion ==0)
        {
            return nodo.Cancion;
        }
        else if (comparacion < 0)
        {
            return BuscarRecursivo(nodo.Izquierdo, titulo);
        }
        else
        {
            return BuscarRecursivo(nodo.Derecho, titulo);
        }
    }
}