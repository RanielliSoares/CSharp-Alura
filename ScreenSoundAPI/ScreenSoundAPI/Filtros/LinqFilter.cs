﻿using ScreenSoundAPI.Modelos;
using System.Linq;

namespace ScreenSoundAPI.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string artista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(artista)).ToList();
        Console.WriteLine($"Musicas do {artista}: \n");
        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }

    public static void FiltrarMusicasPorTonalidade(List<Musica> musicas, int key)
    {
        var musicasPorTonalidade = musicas.Where(musica => musica.Chave!.Equals(key)).ToList();
        foreach (var musica in musicasPorTonalidade)
        {
            Console.WriteLine($"- {musica.Nome} Tonalidade {musica.Tonalidade}");
        }
    }
}

