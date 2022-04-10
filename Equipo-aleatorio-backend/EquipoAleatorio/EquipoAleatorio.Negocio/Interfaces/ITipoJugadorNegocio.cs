namespace EquipoAleatorio.Negocio.Interfaces
{
    using System.Collections.Generic;
    using EquipoAleatorio.Entidades.Contexto;


    public interface ITipoJugadorNegocio
    {
        IEnumerable<TipoJugador> ConsultarTiposJugadores();
    }
}
