namespace EquipoAleatorio.Entidades.Contexto
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Jugador
    {
        [Key]
        public int IdJugador { get; set; }

        [Required]
        public string NombreJugador { get; set; }

        [ForeignKey("TipoJugador")]
        public int IdTipoJugador { get; set; }

        public TipoJugador TipoJugador { get; set; }
    }
}
