namespace VeterinariaLemusWeb.Models;

public class Gato : Mascota
{
    private bool esterilizado;

    public Gato(string nombre, double peso, string sexo, int edad, string propietario, bool esterilizado)
        : base(nombre, peso, sexo, edad, propietario)
    {
        this.esterilizado = esterilizado;
    }

    public bool Esterilizado
    {
        get { return esterilizado; }
        set { esterilizado = value; }
    }

    public override string Tipo => "Gato";

    // Gato: 90 % de la dosis base
    public override double CalcularDosis(double dosisPorKg)
    {
        return Peso * dosisPorKg * 0.9;
    }
}