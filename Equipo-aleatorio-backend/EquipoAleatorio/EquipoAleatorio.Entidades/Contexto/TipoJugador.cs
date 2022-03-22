namespace EquipoAleatorio.Entidades.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text;
    using System.Text.Json.Serialization;

    public class TipoJugador
    {
        public TipoJugador()
        {
            Jugadores = new HashSet<Jugador>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int IdTipoJugador { get; set; }

        public string NombreTipoJugador { get; set; }

        [JsonIgnore] public virtual ICollection<Jugador> Jugadores { get; set; }
    }
}
