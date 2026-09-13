using System.CodeDom;

namespace ReproductorMusicaECYS;

public class NodoCola
{
    public Cancion Cancion { get; set; }
    public NodoCola Siguiente { get; set; }

    public NodoCola(Cancion cancion)
    {
        this.Cancion = cancion;
        this.Siguiente = null; //Al crearse, nadie va despues de el aun
    }
}