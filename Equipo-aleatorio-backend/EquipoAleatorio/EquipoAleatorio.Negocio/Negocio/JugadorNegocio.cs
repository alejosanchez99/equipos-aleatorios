namespace EquipoAleatorio.Negocio.Negocio
{
    using System.Collections.Generic;
    using System.Linq;
    using EquipoAleatorio.AccesoDatos.Interfaces;
    using EquipoAleatorio.Entidades.Contexto;
    using EquipoAleatorio.Negocio.Interfaces;

    public class JugadorNegocio : IJugadorNegocio
    {
        private readonly IJugadorRepositorio jugadorRepositorio;

        public JugadorNegocio(IJugadorRepositorio jugadorRepositorio)
        {
            this.jugadorRepositorio = jugadorRepositorio;
        }

        public void CrearJugador(Jugador jugador)
        {
            this.jugadorRepositorio.Crear(jugador);
        }

        public IEnumerable<Jugador> ConsultarJugadores()
        {
            return this.jugadorRepositorio.Consultar().OrderBy(x => x.IdTipoJugador);
        }
    }
}
