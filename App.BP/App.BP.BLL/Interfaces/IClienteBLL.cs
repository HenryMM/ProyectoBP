using App.BP.Common.DTO;
using App.BP.Data.Models;

namespace App.BP.BLL.Interfaces
{
    public interface IClienteBLL
    {
        Task<List<Cliente>> ObtenerClientesAsync();
        Task<Cliente> CrearClienteAsync(ClienteDTO cliente);
        Task<Cliente> EditarClienteAsync(ClienteDTO clienteDto);
        Task EliminarClienteAsync(int id);
    }
}
