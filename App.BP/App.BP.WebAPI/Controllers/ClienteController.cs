using App.BP.BLL.Interfaces;
using App.BP.Common.DTO;
using App.BP.Data;
using App.BP.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App.BP.WebAPI.Controllers
{
    [Route("api/clientes")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteBLL _clientBLL;
        public ClienteController(IClienteBLL clienteBLL)
        {
            _clientBLL = clienteBLL;
        }

        [HttpGet]
        public async Task<IActionResult> GetClients()
        {
            List<Cliente> clientes = await _clientBLL.ObtenerClientesAsync();
            
            return Ok(clientes);
        }

        [HttpPost]
        public async Task<IActionResult> CrearCliente(ClienteDTO clienteDTO)
        {
            Cliente cliente = await _clientBLL.CrearClienteAsync(clienteDTO);

            return Ok(cliente);
        }

        [HttpPut]
        public async Task<IActionResult> EditarCliente(ClienteDTO clienteDTO)
        {
            Cliente cliente = await _clientBLL.EditarClienteAsync(clienteDTO);

            return Ok(cliente);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarCliente(int id)
        {
            await _clientBLL.EliminarClienteAsync(id);

            return Ok();
        }
    }
}
