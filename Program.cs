using Filmes.Dados;
using Filmes.Negocio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Filmes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new AluraFilmesContexto();

            //var atores = context.Atores.OrderByDescending(a => EF.Property<DateTime>(a, "last_update")).Take(10);

            //foreach (var item in atores)
            //{
            //    Console.WriteLine(item + " - " + context.Entry(item).Property("last_update").CurrentValue);
            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            //var filmes = context.Filmes.OrderByDescending(a => EF.Property<DateTime>(a, "last_update")).Take(10);

            //foreach (var item in filmes)
            //{
            //    Console.WriteLine(item + " - " + context.Entry(item).Property("last_update").CurrentValue);
            //    Console.WriteLine();
            //}

            //var elenco = context.Elenco.OrderByDescending(a => EF.Property<DateTime>(a, "last_update"));

            //foreach (var item in elenco)
            //{
            //    Console.WriteLine(item
            //        + " - "
            //        + context.Entry(item).Property("film_id").CurrentValue
            //        + " - "
            //        + context.Entry(item).Property("actor_id").CurrentValue
            //        + " - "
            //        + context.Entry(item).Property("last_update").CurrentValue);

            //    Console.WriteLine();
            //}

            //var filme = context.Filmes
            //    .Include(f => f.Atores)
            //    .ThenInclude(fa => fa.Ator)
            //    .FirstOrDefault();

            //Console.WriteLine(filme);
            //Console.WriteLine("Elenco: ");

            //foreach(var item in filme.Atores)
            //{
            //    Console.WriteLine(item.Ator);
            //}

            //var filmes = context.Filmes
            //    .Include(f => f.IdiomaFalado);

            //foreach(var filme in filmes)
            //{
            //    Console.WriteLine(filme);
            //    Console.WriteLine(filme.IdiomaFalado);
            //}

            var idiomas = context.Idiomas
                .Include(i => i.FilmesFalados);

            foreach (var idioma in idiomas)
            {
                Console.WriteLine(idioma);

                foreach (var filme in idioma.FilmesFalados)
                {
                    Console.WriteLine(filme);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
