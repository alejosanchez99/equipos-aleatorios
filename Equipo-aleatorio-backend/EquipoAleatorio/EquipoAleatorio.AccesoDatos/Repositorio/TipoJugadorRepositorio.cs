namespace EquipoAleatorio.AccesoDatos.Repositorio
{
    using EquipoAleatorio.AccesoDatos.Context;
    using EquipoAleatorio.AccesoDatos.Interfaces;
    using EquipoAleatorio.Entidades.Contexto;

    public class TipoJugadorRepositorio : RepositorioGenerico<TipoJugador>, ITipoJugadorRepositorio
    {
        public TipoJugadorRepositorio(ApplicationDbContext contexto) : base(contexto) { }
    }
}
