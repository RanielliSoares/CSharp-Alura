using ScreenSoundAPI.Modelos;
using ScreenSoundAPI.Filtros;

using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        //Abaixo temos alguns filtros criados com LINQ


        //Filtra todos os generos musicais
       // LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        
        //Filtra todos os artistas ordenados
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);

        //Filtra os artistas por genero musical
       //LinqOrder.FiltrarArtistaPorGeneroMusical(musicas,"rock");

        LinqFilter.FiltrarMusicasDeUmArtista(musicas,"Imagine Dragons");

        /*foreach(Musica musica in musicas)
        {
            if(musica.Artista == "Kesha")
            {
                musica.ExibirDetalhesDaMusica();
            }
        }
        */
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}