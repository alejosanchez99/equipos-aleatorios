namespace EquipoAleatorioApi.Controllers
{
    using System.Collections.Generic;
    using EquipoAleatorio.Entidades.Contexto;
    using EquipoAleatorio.Entidades.Negocio;
    using EquipoAleatorio.Negocio.Interfaces;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class EquipoController : ControllerBase
    {
        private readonly IEquipoNegocio equipoNegocio;

        public EquipoController(IEquipoNegocio equipoNegocio)
        {
            this.equipoNegocio = equipoNegocio;
        }

        [HttpPost]
        public SeleccionEquipo EscogerEquipos([FromBody] IEnumerable<Jugador> jugadores)
        {
            return this.equipoNegocio.EscogerEquipos(jugadores);
        }
    }
}
