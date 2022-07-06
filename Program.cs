using Filmes.Dados;
using System;

namespace Filmes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AluraFilmesContexto())
            {
                foreach (var ator in context.Atores)
                {
                    Console.WriteLine(ator);
                }
                    Console.ReadLine();
            }
        }
    }
}
