using App.BP.Common.DTO;
using App.BP.Data.Models;

namespace App.BP.BLL.Interfaces
{
    public interface IMovimientoBLL
    {
        Task<List<Movimiento>> ObtenerMovimientosAsync();
        Task<RespuestaGenerica<Movimiento>> CrearMovimientoAsync(MovimientoEfectuado movimiento);
        Task<Movimiento> EditarMovimientoAsync(MovimientoDTO movimientoDTO);
        Task EliminarMovimientoAsync(int id);
        Task<List<Movimiento>> ObtenerMovimientosByAsync(int clienteId, DateTime fecha);
    }
}
