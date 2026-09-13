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

        if (EstaVacia())
        {
            return null;
        }
        
        return cancionExtraida;
    }
    
    //Verifica si hay canciones en espera
    public bool EstaVacia()
    {
        return frente == null;
    }
}