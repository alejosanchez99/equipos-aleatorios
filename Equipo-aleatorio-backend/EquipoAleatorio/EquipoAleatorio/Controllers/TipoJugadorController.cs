namespace EquipoAleatorio.Controllers
{
    using System.Collections.Generic;
    using EquipoAleatorio.Entidades.Contexto;
    using EquipoAleatorio.Negocio.Interfaces;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class TipoJugadorController : ControllerBase
    {
        private readonly ITipoJugadorNegocio tipoJugadorNegocio;

        public TipoJugadorController(ITipoJugadorNegocio tipoJugadorNegocio)
        {
            this.tipoJugadorNegocio = tipoJugadorNegocio;
        }

        [HttpGet]
        public IEnumerable<TipoJugador> ConsultarTiposJugadores()
        {
            return tipoJugadorNegocio.ConsultarTiposJugadores();
        }
    }
}
