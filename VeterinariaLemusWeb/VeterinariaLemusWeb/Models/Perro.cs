namespace VeterinariaLemusWeb.Models;

public class Perro : Mascota
{
    private string raza;

    public Perro(string nombre, double peso, string sexo, int edad, string propietario, string raza)
        : base(nombre, peso, sexo, edad, propietario)
    {
        this.raza = raza;
    }

    public string Raza
    {
        get { return raza; }
        set { raza = value; }
    }

    public override string Tipo => "Perro";

    // Perro: 100 % de la dosis base
    public override double CalcularDosis(double dosisPorKg)
    {
        return Peso * dosisPorKg;
    }
}