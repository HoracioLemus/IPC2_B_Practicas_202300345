namespace VeterinariaLemus;

public class Ave : Mascota
{
    // Atributo extra
    private bool puedeVolar;

    // Constructor (sin raza)
    public Ave(string nombre, double peso, string sexo, int edad, string propietario, bool puedeVolar) : base(nombre, peso, sexo, edad, propietario)
    {
        this.puedeVolar = puedeVolar;
    }

    // Propiedad pública para acceder al atributo extra
    public bool PuedeVolar
    {
        get { return puedeVolar; }
        set { puedeVolar = value; }
    }

    // Cálculo de Dosis
    // Dosis estándar
    public override double CalcularDosis(double dosisPorKg)
    {
        return Peso * dosisPorKg * 0.5; // Dosis estándar para aves
    }

    // Actualizar Info
    public override void MostrarInfo()
    {
        base.MostrarInfo();
        Console.WriteLine($"Puede volar: {((puedeVolar)? "Sí" : "No")}");
        Console.WriteLine("Tipo: Ave");
    }
}