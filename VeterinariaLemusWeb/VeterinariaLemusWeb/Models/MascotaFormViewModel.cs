using System.ComponentModel.DataAnnotations;

namespace VeterinariaLemusWeb.Models;

public class MascotaFormViewModel
{
    public string? Codigo { get; set; }

    [Required(ErrorMessage = "Seleccione el tipo de mascota.")]
    public string Tipo { get; set; } = "";

    [Required(ErrorMessage = "El nombre es obligatorio.")]
    public string Nombre { get; set; } = "";

    [Range(0.01, 1000, ErrorMessage = "El peso debe ser mayor que 0.")]
    public double Peso { get; set; }

    [Required(ErrorMessage = "Seleccione el sexo.")]
    public string Sexo { get; set; } = "";

    [Range(0, 100, ErrorMessage = "La edad debe estar entre 0 y 100.")]
    public int Edad { get; set; }

    [Required(ErrorMessage = "El propietario es obligatorio.")]
    public string Propietario { get; set; } = "";

    // Campos específicos de cada tipo
    public string? Raza { get; set; }              // Perro
    public bool Esterilizado { get; set; }         // Gato
    public bool PuedeVolar { get; set; }           // Ave
    public string? TipoCaparazon { get; set; }     // Tortuga
}