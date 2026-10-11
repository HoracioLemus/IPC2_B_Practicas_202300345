namespace VeterinariaLemusWeb.Models;

public class Ave : Mascota
{
    private bool puedeVolar;

    public Ave(string nombre, double peso, string sexo, int edad, string propietario, bool puedeVolar)
        : base(nombre, peso, sexo, edad, propietario)
    {
        this.puedeVolar = puedeVolar;
    }

    public bool PuedeVolar
    {
        get { return puedeVolar; }
        set { puedeVolar = value; }
    }

    public override string Tipo => "Ave";

    // Ave: 50 % de la dosis base
    public override double CalcularDosis(double dosisPorKg)
    {
        return Peso * dosisPorKg * 0.5;
    }
}