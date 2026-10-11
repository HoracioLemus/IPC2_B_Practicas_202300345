namespace VeterinariaLemusWeb.Models;

public class Tortuga : Mascota
{
    private string tipoCaparazon;

    public Tortuga(string nombre, double peso, string sexo, int edad, string propietario, string tipoCaparazon)
        : base(nombre, peso, sexo, edad, propietario)
    {
        this.tipoCaparazon = tipoCaparazon;
    }

    public string TipoCaparazon
    {
        get { return tipoCaparazon; }
        set { tipoCaparazon = value; }
    }

    public override string Tipo => "Tortuga";

    // Tortuga: 80 % de la dosis base
    public override double CalcularDosis(double dosisPorKg)
    {
        return Peso * dosisPorKg * 0.8;
    }
}