namespace VeterinariaLemus;

public class Tortuga : Mascota
{
    // Atributo extra
    private string tipoCaparazon;

    // Constructor (sin raza)
    public Tortuga(string nombre, double peso, string sexo, int edad, string propietario, string tipoCaparazon) : base(nombre, peso, sexo, edad, propietario)
    {
        this.tipoCaparazon = tipoCaparazon;
    }

    // Propiedad pública para acceder al atributo extra
    public string TipoCaparazon
    {
        get { return tipoCaparazon; }
        set { tipoCaparazon = value; }
    }

    // Cálculo de Dosis
    // Dosis estándar
    public override double CalcularDosis(double dosisPorKg)
    {
        return Peso * dosisPorKg * 0.8; // Dosis estándar para tortugas
    }

    // Actualizar Info
    public override void MostrarInfo()
    {
        base.MostrarInfo();
        Console.WriteLine($"Tipo de caparazón: {tipoCaparazon}");
        Console.WriteLine("Tipo: Tortuga");
    }
}