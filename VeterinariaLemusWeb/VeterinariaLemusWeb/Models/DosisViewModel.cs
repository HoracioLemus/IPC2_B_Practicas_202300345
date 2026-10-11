namespace VeterinariaLemusWeb.Models;

public class DosisViewModel
{
    public string Codigo { get; set; } = "";
    public string Nombre { get; set; } = "";
    public string Tipo { get; set; } = "";
    public double Peso { get; set; }
    public double DosisPorKg { get; set; }
    public double? DosisTotal { get; set; }
}