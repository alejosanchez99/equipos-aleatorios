namespace EquipoAleatorio.Entidades.Negocio
{
    using System.Collections.Generic;
    using EquipoAleatorio.Entidades.Contexto;

    public class Equipo
    {
        public List<Jugador> JugadoresEquipoUno { get; set; }
        public List<Jugador> JugadoresEquipoDos { get; set; }
    }
}
