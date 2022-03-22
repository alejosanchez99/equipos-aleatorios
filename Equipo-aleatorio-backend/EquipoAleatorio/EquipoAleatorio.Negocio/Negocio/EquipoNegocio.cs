namespace EquipoAleatorio.Negocio.Negocio
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using EquipoAleatorio.Entidades.Contexto;
    using EquipoAleatorio.Entidades.Negocio;
    using EquipoAleatorio.Negocio.Interfaces;

    public class EquipoNegocio : IEquipoNegocio
    {
        public SeleccionEquipo EscogerEquipos(IEnumerable<Jugador> jugadores)
        {
            IEnumerable<IGrouping<int, Jugador>> jugadoresAgrupadosPosicion = jugadores.GroupBy(x => x.IdTipoJugador);

            List<Jugador> arqueros = ObtenerJugadoresPorPosicion(jugadoresAgrupadosPosicion, Entidades.Negocio.TipoJugador.Arquero);
            List<Jugador> defensas = ObtenerJugadoresPorPosicion(jugadoresAgrupadosPosicion, Entidades.Negocio.TipoJugador.Defensa);
            List<Jugador> volantes = ObtenerJugadoresPorPosicion(jugadoresAgrupadosPosicion, Entidades.Negocio.TipoJugador.Volante);
            List<Jugador> delanteros = ObtenerJugadoresPorPosicion(jugadoresAgrupadosPosicion, Entidades.Negocio.TipoJugador.Delantero);

            List<Jugador> jugadoresEquipoUno = new List<Jugador>(0);
            List<Jugador> jugadoresEquipoDos = new List<Jugador>(0);

            jugadoresEquipoUno.AddRange(EstablecerJugadoresAleatoriosEquipoUno(arqueros));
            jugadoresEquipoUno.AddRange(EstablecerJugadoresAleatoriosEquipoUno(defensas));
            jugadoresEquipoUno.AddRange(EstablecerJugadoresAleatoriosEquipoUno(volantes));
            jugadoresEquipoUno.AddRange(EstablecerJugadoresAleatoriosEquipoUno(delanteros));

            List<int> idsJugadoresUno = jugadoresEquipoUno.Select(jugadorEquipoUno => jugadorEquipoUno.IdJugador).ToList();

            jugadoresEquipoDos.AddRange(this.EstablecerJugadoresAleatoriosEquipoDos(arqueros, idsJugadoresUno));
            jugadoresEquipoDos.AddRange(this.EstablecerJugadoresAleatoriosEquipoDos(defensas, idsJugadoresUno));
            jugadoresEquipoDos.AddRange(this.EstablecerJugadoresAleatoriosEquipoDos(volantes, idsJugadoresUno));
            jugadoresEquipoDos.AddRange(this.EstablecerJugadoresAleatoriosEquipoDos(delanteros, idsJugadoresUno));


            SeleccionEquipo seleccionEquipo = new SeleccionEquipo
            {
                EquipoUno = new Equipo
                {
                    Jugadores = jugadoresEquipoUno.OrderBy(x => x.IdTipoJugador).ToList()
                },
                EquipoDos = new Equipo
                {
                    Jugadores = jugadoresEquipoDos.OrderBy(x => x.IdTipoJugador).ToList()
                }
            };

            return seleccionEquipo;
        }

        private List<Jugador> EstablecerJugadoresAleatoriosEquipoDos(IEnumerable<Jugador> jugadores, List<int> idsJugadoresUno)
        {
            return jugadores.Where(x => !idsJugadoresUno.Contains(x.IdJugador)).ToList();
        }

        private static List<Jugador> EstablecerJugadoresAleatoriosEquipoUno(List<Jugador> jugadores)
        {
            int valorMaximoGenerado = jugadores.Count - 1;
            int cantidadJugadoresPorTipo = jugadores.Count / 2;

            List<int> indiceJugadoresAleatorios = GenerarIndiceJugadoresAleatorios(valorMaximoGenerado, cantidadJugadoresPorTipo);

            return jugadores.Select((jugador, indice) => (jugador, indice)).Where(jugadorIndice => indiceJugadoresAleatorios.Contains(jugadorIndice.indice)).Select(x => x.jugador).ToList();
        }

        public static List<int> GenerarIndiceJugadoresAleatorios(int valorMaximoGenerado, int cantidadJugadoresPorTipo)
        {
            Random numeroAletorio = new Random();

            int indiceValor = 0;
            List<int> indicesAleatorios = new List<int>(0);

            while (indiceValor < cantidadJugadoresPorTipo)
            {
                int valorNumeroAleatorio = numeroAletorio.Next(0, valorMaximoGenerado);

                if (!indicesAleatorios.Contains(valorNumeroAleatorio))
                {
                    indicesAleatorios.Add(valorNumeroAleatorio);
                    indiceValor++;
                }
            }

            return indicesAleatorios;
        }

        private static List<Jugador> ObtenerJugadoresPorPosicion(IEnumerable<IGrouping<int, Jugador>> jugadoresAgrupadosPosicion, Entidades.Negocio.TipoJugador tipoJugador)
        {
            return jugadoresAgrupadosPosicion.Where(x => x.Key == tipoJugador.GetHashCode()).SelectMany(x => x).ToList();
        }
    }
}
