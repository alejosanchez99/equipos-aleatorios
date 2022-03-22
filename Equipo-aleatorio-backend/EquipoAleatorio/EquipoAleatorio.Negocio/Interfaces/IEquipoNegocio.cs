namespace EquipoAleatorio.Negocio.Interfaces
{
    using System.Collections.Generic;
    using EquipoAleatorio.Entidades.Contexto;
    using EquipoAleatorio.Entidades.Negocio;

    public interface IEquipoNegocio
    {
        SeleccionEquipo EscogerEquipos(IEnumerable<Jugador> jugadores);
    }
}
