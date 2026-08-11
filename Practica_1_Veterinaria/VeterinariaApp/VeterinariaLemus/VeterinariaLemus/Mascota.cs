namespace VeterinariaLemus;
//clase que representa a un paciente de la veterinaria
public abstract class Mascota
{
    //Atributos Privados
    private string nombre;
    private double peso;
    private string sexo;
    private int edad;
    private string propietario;
    private string codigo;
    private bool enfermo;

    //Propiedades Publicas (getters y setters)
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public double Peso
    {
        get { return peso; }
        set { peso = value; }
    }

    public string Sexo
    {
        get { return sexo; }
        set { sexo = value; }
    }

    public int Edad
    {
        get { return edad; }
        set { edad = value; }
    }

    public string Propietario
    {
        get { return propietario; }
        set { propietario = value; }
    }

    public string Codigo
    {
        get { return codigo; }
        private set { codigo = value; }
    }

    public bool Enfermo
    {
        get { return enfermo; }
        private set { enfermo = value; }
    }

    //Constructor
    public Mascota(string nombre, double peso, string sexo, int edad, string propietario)
    {
        this.nombre = nombre;
        this.peso = peso;
        this.sexo = sexo;
        this.edad = edad;
        this.propietario = propietario;
        this.codigo = GenerarCodigo();
        this.enfermo = false;
    }
    
    private string GenerarCodigo()
    {
        //Genera un codigo unico para cada mascota
        const string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        var random = new Random();
        var codigo = new char[8];
        for (int i = 0; i < 8; i++)
        {
            codigo[i] = caracteres[random.Next(caracteres.Length)];
        }
        return new string(codigo);
    }
    
    //Metodos
    public abstract double CalcularDosis(double dosisPorKg);

    public void Cambiar_Estado(bool nuevoEstado)
    {
        this.enfermo = nuevoEstado;
    }
    
    //Mostrar Informacion de la mascota
    public virtual void MostrarInfo()
    {
    Console.WriteLine("Nombre: " + nombre);
    Console.WriteLine("Peso: " + peso + " kg");
    Console.WriteLine("Sexo: " + sexo);
    Console.WriteLine("Edad: " + edad + " años");
    Console.WriteLine("Propietario: " + propietario);
    Console.WriteLine("Codigo: " + codigo);
    Console.WriteLine("Estado: " + (enfermo ? "Enfermo" : "Sano"));
    }   
}