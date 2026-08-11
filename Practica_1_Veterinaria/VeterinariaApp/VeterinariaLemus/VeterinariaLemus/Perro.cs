namespace VeterinariaLemus;

public class Perro : Mascota
{
    //Atributo extra
    private string raza;
    
    

    //Constructor
    public Perro(string nombre, double peso, string sexo, int edad, string propietario, string raza) : base(nombre, peso, sexo, edad, propietario)
    {
        this.raza = raza;
    }

    //Propiedad publica para acceder al atributo extra
    public string Raza
    {
        get { return raza; }
        set { raza = value; }
    }
    
    //Calculo de Dosis
    //Dosis estandar
    public override double CalcularDosis(double dosisPorKg)
    {
        return Peso * dosisPorKg; // Dosis estandar para perros
    }
    
    //Actualizar Info
    public override void MostrarInfo()
    {
        base.MostrarInfo();
        Console.WriteLine($"Raza: {raza}");
        Console.WriteLine("Tipo: Perro");
    }
}