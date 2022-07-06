using Filmes.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Filmes.Dados
{
    public class FilmeAtorConfiguration : IEntityTypeConfiguration<FilmeAtor>
    {
        public void Configure(EntityTypeBuilder<FilmeAtor> builder)
        {
            builder
                .ToTable("film_actor");

            builder
                .Property<int>("film_id")
                .IsRequired();

            builder
                .Property<int>("actor_id")
                .IsRequired();
            
            builder
                .Property<DateTime>("last_update")
                .HasDefaultValueSql("getdate()")
                .IsRequired();

            builder
                .HasKey("film_id", "actor_id");

            builder
                .HasOne(fa => fa.Filme)
                .WithMany(fa => fa.Atores)
                .HasForeignKey("film_id");

            builder
                .HasOne(fa => fa.Ator)
                .WithMany(fa => fa.Filmografia)
                .HasForeignKey("actor_id");
        }
    }
}
