class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome { get;}
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }

    public Genero Genero { get; set; }

    //uma arrow function é conhecida como lambda no C#
    public string DescricaoResumida => $"A Música {Nome} pertence a banda {Artista.Nome}";


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"\nNome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
        Console.WriteLine(DescricaoResumida);
    }
    public void ExibirDadosArtista()
    {
        Console.WriteLine($"\nNome: {Nome} - {Artista.Nome}");
    }
}