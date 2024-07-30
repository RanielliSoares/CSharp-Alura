
namespace ScreenSoundAPI.Modelos;

internal class MusicasPreferidas
{
    public string? Nome { get; set; }
    public List<Musica> ListaDeMusicasFavoritas { get; }

    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        ListaDeMusicasFavoritas = new List<Musica>();
    }

    public void AdicionarMusicasFavoritas(Musica musica)
    {
        ListaDeMusicasFavoritas.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Essas são as musicas favoritas -> {Nome}");
        foreach (var musica in ListaDeMusicasFavoritas) 
        { 
            Console.WriteLine($"Música: {musica.Nome} - Artista: {musica.Artista}");
        }
        Console.WriteLine();
    }

    public void GerarArquivoJson()
    {

    }
}
