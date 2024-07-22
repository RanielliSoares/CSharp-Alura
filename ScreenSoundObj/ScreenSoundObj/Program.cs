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

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);
albumDoBaroes.AdicionarMusica(musica3);

queen.AdicionarAlbum(albumDoQueen);
queen.ExibirDiscografia();
albumDoQueen.ExibirMusicasDoAlbum();

baroesPisada.AdicionarAlbum(albumDoBaroes);
baroesPisada.ExibirDiscografia();
albumDoBaroes.ExibirMusicasDoAlbum();