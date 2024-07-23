class Podcast
{
    private List<Episodio> episodios = new List<Episodio>();
    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
        
    }
    public string Nome { get; }
    public string Host { get; }
    public int TotalEpisodios => episodios.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }
    public void ExibirDetalhesPodcast()
    {
        Console.WriteLine($"Podcast de hoje: {Nome}, Apresentado por: {Host}");
        foreach (Episodio e in episodios)
        {
            Console.WriteLine(e.Resumo);
        }
        Console.WriteLine($"\nEste podcast possui {TotalEpisodios} episódios");
    }
}