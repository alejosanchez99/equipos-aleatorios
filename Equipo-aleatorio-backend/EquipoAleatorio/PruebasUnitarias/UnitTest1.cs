namespace PruebasUnitarias
{
    using System.Collections.Generic;
    using EquipoAleatorio.Entidades.Contexto;
    using EquipoAleatorio.Negocio.Negocio;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<Jugador> jugadores = new List<Jugador>
            {
                new Jugador
                {
                    IdJugador = 1,
                    NombreJugador = "Pity",
                    TipoJugador = new TipoJugador
                    {
                         IdTipoJugador = 1
                    }
                },
                new Jugador
                {
                    IdJugador = 2,
                    NombreJugador = "pauli",
                    TipoJugador = new TipoJugador
                    {
                         IdTipoJugador = 1
                    }
                },
                new Jugador
                {
                    IdJugador = 3,
                    NombreJugador = "Foxquir",
                    TipoJugador = new TipoJugador
                    {
                         IdTipoJugador = 2
                    }
                },
                new Jugador
                {
                    IdJugador = 4,
                    NombreJugador = "Checho",
                    TipoJugador = new TipoJugador
                    {
                         IdTipoJugador = 2
                    }
                },
                new Jugador
                {
                    IdJugador = 5,
                    NombreJugador = "Caliche",
                    TipoJugador = new TipoJugador
                    {
                         IdTipoJugador = 2
                    }
                },
                new Jugador
                {
                    IdJugador = 6,
                    NombreJugador = "Juanjo",
                    TipoJugador = new TipoJugador
                    {
                         IdTipoJugador = 2
                    }
                },
                new Jugador
                {
                    IdJugador = 7,
                    NombreJugador = "Simón",
                    TipoJugador = new TipoJugador
                    {
                         IdTipoJugador = 2
                    }
                },
                new Jugador
                {
                    IdJugador = 8,
                    NombreJugador = "Santi",
                    TipoJugador = new TipoJugador
                    {
                         IdTipoJugador = 2
                    }
                },
                new Jugador
                {
                    IdJugador = 9,
                    NombreJugador = "Pablo ",
                    TipoJugador = new TipoJugador
                    {
                         IdTipoJugador = 2
                    }
                },
                new Jugador
                {
                    IdJugador = 10,
                    NombreJugador = "Carcamo",
                    TipoJugador = new TipoJugador
                    {
                         IdTipoJugador = 2
                    }
                },
                new Jugador
                {
                    IdJugador = 11,
                    NombreJugador = "Santiago",
                    TipoJugador = new TipoJugador
                    {
                         IdTipoJugador = 3
                    }
                },
                new Jugador
                {
                    IdJugador = 12,
                    NombreJugador = "Thomy",
                    TipoJugador = new TipoJugador
                    {
                         IdTipoJugador = 3
                    }
                },
                new Jugador
                {
                    IdJugador = 13,
                    NombreJugador = "Alejandro ",
                    TipoJugador = new TipoJugador
                    {
                         IdTipoJugador = 3
                    }
                },
                new Jugador
                {
                    IdJugador = 14,
                    NombreJugador = "Lucho ",
                    TipoJugador = new TipoJugador
                    {
                         IdTipoJugador = 3
                    }
                },
                new Jugador
                {
                    IdJugador = 15,
                    NombreJugador = "Yepes ",
                    TipoJugador = new TipoJugador
                    {
                         IdTipoJugador = 3
                    }
                },
                new Jugador
                {
                    IdJugador = 16,
                    NombreJugador = "Rolo ",
                    TipoJugador = new TipoJugador
                    {
                         IdTipoJugador = 3
                    }
                },
                new Jugador
                {
                    IdJugador = 17,
                    NombreJugador = "Camilo",
                    TipoJugador = new TipoJugador
                    {
                         IdTipoJugador = 4
                    }
                },
                new Jugador
                {
                    IdJugador = 18,
                    NombreJugador = "Danielito ",
                    TipoJugador = new TipoJugador
                    {
                         IdTipoJugador = 4
                    }
                },
                new Jugador
                {
                    IdJugador = 19,
                    NombreJugador = "Pana tutis ",
                    TipoJugador = new TipoJugador
                    {
                         IdTipoJugador = 4
                    }
                },
                new Jugador
                {
                    IdJugador = 20,
                    NombreJugador = "Pana tutis 2",
                    TipoJugador = new TipoJugador
                    {
                         IdTipoJugador = 4
                    }
                },
                new Jugador
                {
                    IdJugador = 21,
                    NombreJugador = "Juangui perro",
                    TipoJugador = new TipoJugador
                    {
                         IdTipoJugador = 4
                    }
                },
                new Jugador
                {
                    IdJugador = 22,
                    NombreJugador = "Alejito",
                    TipoJugador = new TipoJugador
                    {
                         IdTipoJugador = 4
                    }
                }
            };

            EquipoNegocio equipo = new EquipoNegocio();

            
            equipo.EscogerEquipos(jugadores);

        }
    }
}
