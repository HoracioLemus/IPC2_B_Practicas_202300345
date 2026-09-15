namespace ReproductorMusicaECYS;
using System.Text.Json.Serialization;
public class Cancion
{
    // lectura de Json
    [JsonPropertyName("titulo")]
    public string Titulo { get; set; }
    
    [JsonPropertyName("artista")]
    public string Artista { get; set; }
    
    [JsonPropertyName("genero")]
    public string Genero { get; set; }
    
    [JsonPropertyName("duracion")]
    public string Duracion { get; set; }
}