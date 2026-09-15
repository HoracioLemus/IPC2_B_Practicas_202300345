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

    public string ObtenerCodigoGraphviz()
    {
        string dot = "digraph G {\n";
        dot += " node [shale=box, style=\"filled,rounded\", fillcolor=\"#c8e6c9\", fontname=\"Arial\"];\n ";

        if (raiz == null)
        {
            dot += " vacio [label=\"Arbol Vacio\", shape=plaintext, fontcolor=red];\n";
        }
        else
        {
            int contador = 0;
            dot += GeneradorDotRecursivo(raiz, ref contador);
        }

        dot += "}\n";
        return dot;
    }

    private string GeneradorDotRecursivo(NodoArbol nodo, ref int contador)
    {
        string resultado = "";
        int idActual = contador;

        string tituloLimpio = nodo.Cancion.Titulo.Replace("\"", "").Replace("{", "").Replace("}","").Replace("|","");
        string artistaLimpio = nodo.Cancion.Artista.Replace("\"", "").Replace("{", "").Replace("}","").Replace("|","");

        resultado += $" nodo{idActual} [label=\"{tituloLimpio}\\n{artistaLimpio}\"];\n";

        if (nodo.Izquierdo != null)
        {
            contador++;
            int idIzquierdo = contador;
            resultado += $" nodo{idActual} -> nodo{idIzquierdo} [color=blue, label=\"Izq\"];\n";
            resultado += GeneradorDotRecursivo(nodo.Izquierdo, ref contador);
        }

        if (nodo.Derecho !=null)
        {
            contador++;
            int idDerecho = contador;
            resultado += $" nodo{idActual} -> nodo{idDerecho} [color=red, label=\"Der\"];\n";
            resultado += GeneradorDotRecursivo(nodo.Derecho, ref contador);
        }

        return resultado;
    }
}