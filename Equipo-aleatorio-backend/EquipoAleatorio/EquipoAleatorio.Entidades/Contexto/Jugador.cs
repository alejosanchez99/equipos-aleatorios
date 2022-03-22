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

        [ForeignKey("TipoJugador")]
        public int IdTipoJugador { get; set; }

        public string NombreTipoJugador => this.TipoJugador.NombreTipoJugador;

        [JsonIgnore] public virtual TipoJugador TipoJugador { get; set; }
    }
}
