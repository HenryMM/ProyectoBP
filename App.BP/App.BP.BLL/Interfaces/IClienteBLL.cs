using App.BP.Common.DTO;
using App.BP.Data.Models;

namespace App.BP.BLL.Interfaces
{
    public interface IClienteBLL
    {
        Task<List<Cliente>> ObtenerClientes();

        Task<Cliente> CrearCliente(ClienteDTO cliente);
        Task<Cliente> EditarCliente(ClienteDTO clienteDto);
        Task EliminarCliente(int id);
    }
}
