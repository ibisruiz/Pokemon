using Microsoft.EntityFrameworkCore;
using PokePoke.Core.Domain;
using PokePoke.Core.Domain.Entities;

namespace PokePoke.Infrastructure.Persistence.Context
{
    public class ApplicationContext : DbContext
    {

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<Pokemonn> Pokemonns { get; set; }
        public DbSet<Tipo> Tipos { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<PokemonTipo> PokemonTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Tables
            modelBuilder.Entity<Pokemonn>().ToTable("Pokemones");
            modelBuilder.Entity<Tipo>().ToTable("Tipos");
            modelBuilder.Entity<Region>().ToTable("Regiones");
            modelBuilder.Entity<PokemonTipo>().ToTable("PokemonesTipos");
            #endregion

            #region "Primary Keys"
            modelBuilder.Entity<Pokemonn>().HasKey(pokemon => pokemon.Id);
            modelBuilder.Entity<Tipo>().HasKey(tipo => tipo.Id);
            modelBuilder.Entity<Region>().HasKey(region => region.Id);
            modelBuilder.Entity<PokemonTipo>().HasKey(pt => new { pt.PokemonId, pt.TipoId });
            #endregion

            #region Relationships
            modelBuilder.Entity<Pokemonn>()
                .HasMany(pokemon => pokemon.PokemonesTipos)
                .WithOne(pt => pt.Pokemon)
                .HasForeignKey(pt => pt.PokemonId);

            modelBuilder.Entity<Tipo>()
                .HasMany(tipo => tipo.PokemonesTipos)
                .WithOne(pt => pt.Tipo)
                .HasForeignKey(pt => pt.TipoId);

            modelBuilder.Entity<Region>()
                .HasMany(region => region.Pokemones)
                .WithOne(pokemon => pokemon.Region)
                .HasForeignKey(pokemon => pokemon.RegionId);

            #endregion





        }

    }
}
