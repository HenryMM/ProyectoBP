using App.BP.BLL.Interfaces;
using App.BP.Common.DTO;
using Microsoft.AspNetCore.Mvc;

namespace App.BP.WebAPI.Controllers
{
    [Route("api/tarjeta")]
    [ApiController]
    public class TarjetaController : ControllerBase
    {
        private readonly ITarjetaBLL _tarjetaBLL;
        public TarjetaController(ITarjetaBLL clienteBLL)
        {
            _tarjetaBLL = clienteBLL;
        }

        /// <summary>
        /// Consultar una tarjeta
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetTarjeta(string numeroTarjeta)
        {
            TarjetaResumen tarjetaResumen = await _tarjetaBLL.ObtenerTarjeta(numeroTarjeta);
            
            return Ok(tarjetaResumen);
        }

    }
}
