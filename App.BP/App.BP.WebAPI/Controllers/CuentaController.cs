using App.BP.BLL.BLL;
using App.BP.BLL.Interfaces;
using App.BP.Common.DTO;
using App.BP.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.BP.WebAPI.Controllers
{
    [Route("api/cuentas")]
    [ApiController]
    public class CuentaController : ControllerBase
    {
        private readonly ICuentaBLL _cuentaBLL;
        public CuentaController(ICuentaBLL cuentaBLL)
        {
            _cuentaBLL = cuentaBLL;
        }

        [HttpGet]
        public async Task<IActionResult> GetCuentas()
        {
            List<Cuenta> cuentas = await _cuentaBLL.ObtenerCuentasAsync();

            return Ok(cuentas);
        }

        [HttpPost]
        public async Task<IActionResult> CrearCuenta(Cuenta cuenta)
        {
            Cuenta record = await _cuentaBLL.CrearCuentaAsync(cuenta);

            return Ok(record);
        }

        [HttpPut]
        public async Task<IActionResult> EditarCuenta(Cuenta cuenta)
        {
            Cuenta record = await _cuentaBLL.EditarCuentaAsync(cuenta);

            return Ok(record);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarCuenta(int id)
        {
            await _cuentaBLL.EliminarCuentaAsync(id);

            return Ok();
        }
    }
}
