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


        // ** Solução sugerida pela alura das tonalidades
        //Criar o array abaixo:
        private string[] tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };
        // Depois criar uma property igual a abaixo
        public string Tonalidade
        {
            get
            {
                return tonalidades[Chave];
            }
        }
        /*
         após isso quando for chamar, chamar a property tonalidade nelá irá vir o indice da key
         */
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
