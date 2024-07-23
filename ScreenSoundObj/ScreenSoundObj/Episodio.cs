class Episodio
{
    private List<string> convidados = new();
    public Episodio(int ordem, string titulo, int duracao)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
    }

    public int Ordem { get; }
    public string Titulo { get; }
    public int Duracao { get; }
    public string Resumo => $"Ep: {Ordem}. \nTema: {Titulo} \nTempo: ({Duracao} min) \nConvidados: {string.Join(", ", convidados)}\n";

    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }
}