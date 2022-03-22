namespace EquipoAleatorio.Entidades.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text;

    public class TipoJugador
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int IdTipoJugador { get; set; }

        public string NombreTipoJugador { get; set; }

        public ICollection<Jugador> Jugadores { get; set; }
    }
}
