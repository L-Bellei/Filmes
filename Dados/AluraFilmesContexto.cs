using Filmes.Negocio;
using Microsoft.EntityFrameworkCore;

namespace Filmes.Dados
{
    public class AluraFilmesContexto : DbContext
    {
        public DbSet<Ator> Atores { get; set; }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<FilmeAtor> Elenco  { get; set; }
        public DbSet<Idioma> Idiomas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Data Source=LAPTOP-RIO81TIC\SQLEXPRESS;Initial Catalog=AluraFilmes;Integrated Security=True;
                                        Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                        MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AtorConfiguration());

            modelBuilder.ApplyConfiguration(new FilmeConfiguration());

            modelBuilder.ApplyConfiguration(new FilmeAtorConfiguration());

            modelBuilder.ApplyConfiguration(new IdiomaConfiguration());
        }
    }
}
