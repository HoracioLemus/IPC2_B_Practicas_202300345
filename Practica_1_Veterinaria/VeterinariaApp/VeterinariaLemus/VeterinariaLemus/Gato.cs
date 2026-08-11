namespace VeterinariaLemus;

public class Gato : Mascota
{
    // Atributo extra
    private bool esterilizado;

    // Constructor (sin raza)
    public Gato(string nombre, double peso, string sexo, int edad, string propietario, bool esterilizado) : base(nombre, peso, sexo, edad, propietario)
    {
        this.esterilizado = esterilizado;
    }

    // Propiedad pública para acceder al atributo extra
    public bool Esterilizado
    {
        get { return esterilizado; }
        set { esterilizado = value; }
    }

    // Cálculo de Dosis
    // Dosis estándar
    public override double CalcularDosis(double dosisPorKg)
    {
        return Peso * dosisPorKg * 0.9; // Dosis estándar para gatos
    }

    // Actualizar Info
    public override void MostrarInfo()
    {
        base.MostrarInfo();
        Console.WriteLine($"Esterilizado: {((esterilizado)? "Sí" : "No")}");
        Console.WriteLine("Tipo: Gato");
    }
}