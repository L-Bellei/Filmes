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
            using (var context = new AluraFilmesContexto())
            {
                var atores = context.Atores.OrderByDescending(a => EF.Property<DateTime>(a, "last_update")).Take(10);

                foreach (var item in atores)
                {
                    Console.WriteLine(item + " - " + context.Entry(item).Property("last_update").CurrentValue);
                    Console.WriteLine();
                }

                Console.WriteLine();

                var filmes = context.Filmes.OrderByDescending(a => EF.Property<DateTime>(a, "last_update")).Take(10);

                foreach (var item in filmes)
                {
                    Console.WriteLine(item + " - " + context.Entry(item).Property("last_update").CurrentValue);
                    Console.WriteLine();
                }

                Console.ReadLine();
            }
        }
    }
}
