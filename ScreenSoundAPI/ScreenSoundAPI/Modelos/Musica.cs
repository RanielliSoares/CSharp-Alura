using System.Text.Json.Serialization;

namespace ScreenSoundAPI.Modelos
{
    internal class Musica
    {

        [JsonPropertyName("song")]
        public string? Nome {  get; set; }

        [JsonPropertyName("artist")]
        public string? Artista { get; set; }

        [JsonPropertyName("duration_ms")]
        public int? Duracao { get; set; }

        [JsonPropertyName("genre")]
        public string? Genero { get; set; }

        [JsonPropertyName("key")]
        public int Chave { get; set; }

        public void ExibirDetalhesDaMusica()
        {
            Console.WriteLine($"Artista: {Artista}");
            Console.WriteLine($"Música: {Nome}");
            Console.WriteLine($"Gênero: {Genero}");
            Console.WriteLine($"Duração: {Duracao /1000}s");
            Console.WriteLine($"Tonalidade recebida: {Chave}\n");

        }
    }
}
