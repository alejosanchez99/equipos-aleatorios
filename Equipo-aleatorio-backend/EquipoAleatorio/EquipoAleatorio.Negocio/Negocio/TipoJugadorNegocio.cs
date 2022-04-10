namespace EquipoAleatorio.Negocio.Negocio
{
    using System.Collections.Generic;
    using System.Linq;
    using EquipoAleatorio.AccesoDatos.Interfaces;
    using EquipoAleatorio.Entidades.Contexto;
    using EquipoAleatorio.Negocio.Interfaces;

    public class TipoJugadorNegocio : ITipoJugadorNegocio
    {
        private readonly ITipoJugadorRepositorio tipoJugadorRepositorio;

        public TipoJugadorNegocio(ITipoJugadorRepositorio tipoJugadorRepositorio)
        {
            this.tipoJugadorRepositorio = tipoJugadorRepositorio;
        }
        public IEnumerable<TipoJugador> ConsultarTiposJugadores()
        {
            return this.tipoJugadorRepositorio.Consultar().OrderBy(x=> x.IdTipoJugador);
        }
    }
}
