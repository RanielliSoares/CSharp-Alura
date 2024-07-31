﻿using ScreenSoundAPI.Modelos;
using ScreenSoundAPI.Filtros;

using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        LinqFilter.FiltrarMusicasPorTonalidade(musicas, 8);
        /*****
        Abaixo temos alguns filtros criados com LINQ
        Filtra todos os generos musicais
        LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        Filtra todos os artistas ordenados
        LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        Filtra os artistas por genero musical
        LinqOrder.FiltrarArtistaPorGeneroMusical(musicas,"rock");
        LinqFilter.FiltrarMusicasDeUmArtista(musicas,"Imagine Dragons");

        ******* aqui com ForEach ****
        foreach(Musica musica in musicas)
        {
            if(musica.Artista == "Kesha")
            {
                musica.ExibirDetalhesDaMusica();
            }
        }
        
        
        var musicasPreferidasDoDaniel = new MusicasPreferidas("Daniel");
        musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1]);
        musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[2]);
        musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[100]);
        musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[189]);
        musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[259]);

        musicasPreferidasDoDaniel.ExibirMusicasFavoritas();

        var musicasPreferidasDoJoao = new MusicasPreferidas("Joao");
        musicasPreferidasDoJoao.AdicionarMusicasFavoritas(musicas[1]);
        musicasPreferidasDoJoao.AdicionarMusicasFavoritas(musicas[526]);
        musicasPreferidasDoJoao.AdicionarMusicasFavoritas(musicas[1051]);
        musicasPreferidasDoJoao.AdicionarMusicasFavoritas(musicas[1052]);
        musicasPreferidasDoJoao.AdicionarMusicasFavoritas(musicas[1085]);
        musicasPreferidasDoJoao.AdicionarMusicasFavoritas(musicas[190]);
        musicasPreferidasDoJoao.AdicionarMusicasFavoritas(musicas[111]);
        musicasPreferidasDoJoao.AdicionarMusicasFavoritas(musicas[105]);

        musicasPreferidasDoJoao.ExibirMusicasFavoritas();

        musicasPreferidasDoJoao.GerarArquivoJson();

                  musicasPreferidasDoDaniel.GerarDocumentoTXTComAsMusicasFavoritas();
       */
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}