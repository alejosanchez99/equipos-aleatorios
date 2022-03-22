namespace EquipoAleatorio.AccesoDatos.Context
{
    using EquipoAleatorio.Entidades.Contexto;
    using Microsoft.EntityFrameworkCore;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public DbSet<TipoJugador> TipoJugador { get; set; }
        public DbSet<Jugador> Jugador { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Jugador>(entity =>
            {
                entity.HasIndex(p => p.NombreJugador).IsUnique();
            });
        }
    }
}
