using App.BP.BLL.Interfaces;
using App.BP.Common.DTO;
using App.BP.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.BP.WebAPI.Controllers
{
    [Route("api/movimientos")]
    [ApiController]
    public class MovimientoController : ControllerBase
    {

        private readonly IMovimientoBLL _movimientoBLL;
        public MovimientoController(IMovimientoBLL movimientoBLL)
        {
            _movimientoBLL = movimientoBLL;
        }

        [HttpGet]
        public async Task<IActionResult> GetMovimientos()
        {
            List<Movimiento> cuentas = await _movimientoBLL.ObtenerMovimientosAsync();

            return Ok(cuentas);
        }

        [HttpGet("{clienteId}/{fecha}")]
        public async Task<IActionResult> GetMovimientos(int clienteId, DateTime fecha)
        {
            List<Movimiento> cuentas = await _movimientoBLL.ObtenerMovimientosByAsync(clienteId, fecha);

            return Ok(cuentas);
        }

        [HttpPost]
        public async Task<IActionResult> CrearMovimiento(MovimientoEfectuado movimiento)
        {
            RespuestaGenerica<Movimiento> record = await _movimientoBLL.CrearMovimientoAsync(movimiento);

            return Ok(record);
        }

        [HttpPut]
        public async Task<IActionResult> EditarCuenta(MovimientoDTO movimiento)
        {
            Movimiento record = await _movimientoBLL.EditarMovimientoAsync(movimiento);

            return Ok(record);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarMovimiento(int id)
        {
            await _movimientoBLL.EliminarMovimientoAsync(id);

            return Ok();
        }


    }
}
