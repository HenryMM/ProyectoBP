using App.BP.Common.DTO;
using App.BP.Data.Models;

namespace App.BP.BLL.Interfaces
{
    public interface ICuentaBLL
    {
        Task<List<Cuenta>> ObtenerCuentasAsync();
        Task<Cuenta> CrearCuentaAsync(Cuenta cuenta);
        Task<Cuenta> EditarCuentaAsync(Cuenta cuenta);
        Task EliminarCuentaAsync(int id);
    }
}
