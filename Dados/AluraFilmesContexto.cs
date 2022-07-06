using Filmes.Negocio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmes.Dados
{
    public class AluraFilmesContexto : DbContext
    {
        public DbSet<Ator> Atores { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Data Source=LAPTOP-RIO81TIC\SQLEXPRESS;Initial Catalog=FilmesTst;Integrated Security=True;
                                        Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                        MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ator>().ToTable("actor");

            modelBuilder.Entity<Ator>().Property(a => a.Id).HasColumnName("actor_id");

            modelBuilder.Entity<Ator>().Property(a => a.PrimeiroNome).HasColumnName("first_name").HasColumnType("varchar(45)").IsRequired();

            modelBuilder.Entity<Ator>().Property(a => a.UltimoNome).HasColumnName("last_name").HasColumnType("varchar(45)").IsRequired();

            modelBuilder.Entity<Ator>().Property<DateTime>("last_update");
        }
    }
}
