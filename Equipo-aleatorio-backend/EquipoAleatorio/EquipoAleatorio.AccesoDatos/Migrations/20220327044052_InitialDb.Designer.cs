// <auto-generated />
using EquipoAleatorio.AccesoDatos.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EquipoAleatorio.AccesoDatos.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220327044052_InitialDb")]
    partial class InitialDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EquipoAleatorio.Entidades.Contexto.Jugador", b =>
                {
                    b.Property<int>("IdJugador")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdTipoJugador")
                        .HasColumnType("int");

                    b.Property<string>("NombreJugador")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IdJugador");

                    b.HasIndex("IdTipoJugador");

                    b.HasIndex("NombreJugador")
                        .IsUnique();

                    b.ToTable("Jugador");
                });

            modelBuilder.Entity("EquipoAleatorio.Entidades.Contexto.TipoJugador", b =>
                {
                    b.Property<int>("IdTipoJugador")
                        .HasColumnType("int");

                    b.Property<string>("NombreTipoJugador")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTipoJugador");

                    b.ToTable("TipoJugador");
                });

            modelBuilder.Entity("EquipoAleatorio.Entidades.Contexto.Jugador", b =>
                {
                    b.HasOne("EquipoAleatorio.Entidades.Contexto.TipoJugador", "TipoJugador")
                        .WithMany("Jugadores")
                        .HasForeignKey("IdTipoJugador")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoJugador");
                });

            modelBuilder.Entity("EquipoAleatorio.Entidades.Contexto.TipoJugador", b =>
                {
                    b.Navigation("Jugadores");
                });
#pragma warning restore 612, 618
        }
    }
}
