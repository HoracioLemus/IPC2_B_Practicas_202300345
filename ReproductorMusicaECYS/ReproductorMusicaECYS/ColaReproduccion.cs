namespace ReproductorMusicaECYS;

public class ColaReproduccion
{
    private NodoCola frente;
    private NodoCola final;

    public ColaReproduccion()
    {
        frente = null;
        final = null;
    }
    
    //Método para agregar canciones
    public void Encolar(Cancion cancion)
    {
        NodoCola nuevoNodo = new NodoCola(cancion);
        
        if (EstaVacia())
        {
            frente = nuevoNodo;
            final = nuevoNodo;
        }
        else
        {
            final.Siguiente = nuevoNodo;
            final = nuevoNodo;
        }
    }

    public Cancion Desencolar()
    {
        if (EstaVacia())
        {
            return null;
        }

        Cancion cancionExtraida = frente.Cancion;
        frente = frente.Siguiente;

        if (frente==null)
        {
            final = null;
        }
        
        return cancionExtraida;
    }
    
    //Verifica si hay canciones en espera
    public bool EstaVacia()
    {
        return frente == null;
    }
    
    //Diagrama Graphiz
    public string ObtenerCodigoGraphviz()
    {
        string dot = "digraph G {\n";
        dot += "  rankdir=LR;\n"; // De izquierda a derecha
        dot += "  node [shape=box, style=\"filled,rounded\", fillcolor=\"#a8d5e2\", fontname=\"Arial\"];\n";
    
        NodoCola actual = frente;
        int contador = 0;

        if (actual == null)
        {
            dot += "  vacio [label=\"Cola Vacía\", shape=plaintext, fontcolor=red];\n";
        }
        else
        {
            while (actual != null)
            {
                string idNodo = $"nodo{contador}";
            
                // Limpiamos CUALQUIER carácter que pueda hacer explotar a Graphviz
                string tituloLimpio = actual.Cancion.Titulo.Replace("\"", "").Replace("{", "").Replace("}", "").Replace("|", "");
                string artistaLimpio = actual.Cancion.Artista.Replace("\"", "").Replace("{", "").Replace("}", "").Replace("|", "");
            
                dot += $"  {idNodo} [label=\"{tituloLimpio}\\n{artistaLimpio}\"];\n";

                if (actual.Siguiente != null)
                {
                    string idSiguiente = $"nodo{contador + 1}";
                    dot += $"  {idNodo} -> {idSiguiente};\n";
                }

                actual = actual.Siguiente;
                contador++;
            }
        }

        dot += "}\n";
        return dot;
    }
    }
