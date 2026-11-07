
using System.Text.Json.Serialization;

namespace SearchDemonSlayerAPI.Models;

public class Personagem
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public int? Age { get; set; }
    public string Race { get; set; } = "";
    public string Quote { get; set; } = "";
    public string Img { get; set; } = "";
}

public class RespostaApi
{
    [JsonPropertyName("content")]
    public List<Personagem> Content { get; set; } = new();

    [JsonPropertyName("pagination")]
    public Paginacao Pagination { get; set; } = new();
}

public class Paginacao
{
    public int TotalPages { get; set; }
}
