namespace EquipoAleatorio.Entidades.Contexto
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text.Json.Serialization;

    public class Jugador
    {
        [Key]
        public int IdJugador { get; set; }

        [Required]
        public string NombreJugador { get; set; }

        [ForeignKey(nameof(TipoJugador))]
        public int IdTipoJugador { get; set; }

       public virtual TipoJugador TipoJugador { get; set; }
    }
}
