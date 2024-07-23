Banda queen = new Banda("Queen");

Banda baroesPisada = new Banda("Baroes da Pisadinha");

Album albumDoQueen = new Album("A night at the opera");

Album albumDoBaroes = new Album("Bagunça e Festa");

Musica musica1 = new Musica(queen, "Love of my life")
{
    Duracao = 213,
    Disponivel = true
};


Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 314,
    Disponivel = true
};

Musica musica3 = new Musica(baroesPisada, "Fiesta Loca")
{
    Duracao = 527,
    Disponivel = true
};

Podcast podcastProg = new Podcast("Alura programações", "Alura Academy");

Episodio ep1 = new Episodio(1, "Técnicas de facilitação", 45);
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("João");
ep1.AdicionarConvidados("Marcelo");

Episodio ep2 = new Episodio(2, "Técnicas de Aprendizado", 57);
ep2.AdicionarConvidados("Pedro");
ep2.AdicionarConvidados("Gabriel");
ep2.AdicionarConvidados("Roberto");

Episodio ep3 = new Episodio(3, "Técnicas de auto conhecimento", 62);
ep3.AdicionarConvidados("Paula");
ep3.AdicionarConvidados("Ruan");
ep3.AdicionarConvidados("Miguel");


podcastProg.AdicionarEpisodio(ep1);
podcastProg.AdicionarEpisodio(ep2);
podcastProg.AdicionarEpisodio(ep3);

podcastProg.ExibirDetalhesPodcast();
/*
albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);
albumDoBaroes.AdicionarMusica(musica3);

queen.AdicionarAlbum(albumDoQueen);
queen.ExibirDiscografia();
albumDoQueen.ExibirMusicasDoAlbum();

baroesPisada.AdicionarAlbum(albumDoBaroes);
baroesPisada.ExibirDiscografia();
albumDoBaroes.ExibirMusicasDoAlbum();

musica3.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
musica1.ExibirFichaTecnica();
*/