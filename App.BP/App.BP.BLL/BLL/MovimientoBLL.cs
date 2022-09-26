using App.BP.BLL.Interfaces;
using App.BP.Common.DTO;
using App.BP.Data.Models;
using App.BP.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace App.BP.BLL.BLL
{
    public class MovimientoBLL : IMovimientoBLL
    {
        private IRepository<Movimiento> _repositoryMovimiento;
        private IRepository<Cuenta> _repositoryCuenta;

        public MovimientoBLL(IRepository<Movimiento> repository, IRepository<Cuenta> repositoryCuenta)
        {
            _repositoryMovimiento = repository;
            _repositoryCuenta = repositoryCuenta;
        }


        #region Public Methods
        public async Task<RespuestaGenerica<Movimiento>> CrearMovimientoAsync(MovimientoEfectuado movimientoEfectuado)
        {
            int saldoActual = await ObtenerSaldoActual(movimientoEfectuado);
            DateTime fechaActual = DateTime.Now;

            Movimiento movimiento = new Movimiento
            {
                CuentaId = movimientoEfectuado.CuentaId,
                Fecha = fechaActual,
                Estado = true,
                MovimientoRealizado = movimientoEfectuado.CantidadMovimiento,
                SaldoInicial  = saldoActual,
                Tipo = movimientoEfectuado.Tipo
            };

            if (movimientoEfectuado.Tipo == "Credito")
            {
                saldoActual += movimientoEfectuado.CantidadMovimiento;
                movimiento.SaldoDisponible = saldoActual;
            }
            else
            {
                RespuestaGenerica<Movimiento> result = await ValidarDebito(saldoActual, movimientoEfectuado, fechaActual);

                if (result.IsSuccess)
                {
                    saldoActual -= movimiento.MovimientoRealizado;
                    movimiento.SaldoDisponible = saldoActual;
                }
                else
                {
                    return result;
                }
            }

            await _repositoryMovimiento.CreateEntityAsync(movimiento);
            await _repositoryMovimiento.SaveAsync();
            return new RespuestaGenerica<Movimiento>
            {
                IsSuccess = true,
                Mensaje = "Movimiento realizado satisfactoriamente."
            }; ;
        }

        public async Task<Movimiento> EditarMovimientoAsync(MovimientoDTO movimiento)
        {
            Movimiento movimientoOriginal = await _repositoryMovimiento.GetEntityByIdAsync(movimiento.Id);

            movimientoOriginal.Estado = movimiento.Estado;

            await _repositoryMovimiento.UpdateEntityAsync(movimientoOriginal);
            await _repositoryMovimiento.SaveAsync();
            return movimientoOriginal;
        }

        public async Task EliminarMovimientoAsync(int id)
        {
            await _repositoryMovimiento.DeleteEntityAsync(id);
            await _repositoryMovimiento.SaveAsync();
        }

        public async Task<List<Movimiento>> ObtenerMovimientosAsync()
        {
            var query = await _repositoryMovimiento.GetAllAsync();

            List<Movimiento> movimientos = await query.ToListAsync();
            return movimientos;
        }

        public async Task<List<Movimiento>> ObtenerMovimientosByAsync(int clienteId, DateTime fecha)
        {
            var query = await _repositoryMovimiento.SearchByAsync(r => r.Fecha == fecha && r.Cuenta.Cliente.Id == clienteId);

            List<Movimiento> movimientos = await query.ToListAsync();
            return movimientos;
        }
        #endregion

        #region Private Methods
        private async Task<int> ObtenerSaldoActual(MovimientoEfectuado movimiento)
        {
            int saldoActual = 0;
            var query = await _repositoryMovimiento.SearchByAsync(m => m.CuentaId == movimiento.CuentaId);

            int numeroMovimientos = query.Count();

            if (numeroMovimientos > 0)
            {
                Movimiento ultimoMovimiento = await query.OrderByDescending(m => m.Fecha).FirstOrDefaultAsync();
                saldoActual = ultimoMovimiento.SaldoDisponible;
            }
            else
            {
                Cuenta cuenta = await _repositoryCuenta.GetEntityByIdAsync(movimiento.CuentaId);
                saldoActual = cuenta.SaldoInicial;
            }
            return saldoActual;
        }

        private async Task<RespuestaGenerica<Movimiento>> ValidarDebito(int saldoActual, MovimientoEfectuado movimientoEfectuado,DateTime fechaActual)
        {
            int limiteDiario = 500;
            RespuestaGenerica<Movimiento> respuestaGenerica = new RespuestaGenerica<Movimiento>
            {
                IsSuccess = true,
                Mensaje = string.Empty
            };

            if (saldoActual == 0)
            {
                respuestaGenerica.IsSuccess = false;
                respuestaGenerica.Mensaje = "Saldo no disponible.";
            }
            else if (saldoActual < movimientoEfectuado.CantidadMovimiento)
            {
                respuestaGenerica.IsSuccess = false;
                respuestaGenerica.Mensaje = "No se pudo realizar la transacción, el saldo disponible es insuficiente.";
            }
            else
            {
                var movimientoDiarioQuery = await _repositoryMovimiento.SearchByAsync(
                   m => m.CuentaId == movimientoEfectuado.CuentaId && m.Fecha == fechaActual && m.Tipo == "Debito");

                List<Movimiento> movimientosDia = await movimientoDiarioQuery.ToListAsync();

                int cantidadMovimientoDia = movimientosDia.Select(m => m.MovimientoRealizado).Sum() + movimientoEfectuado.CantidadMovimiento;

                if (cantidadMovimientoDia > limiteDiario)
                {
                    respuestaGenerica.IsSuccess = false;
                    respuestaGenerica.Mensaje = "Cupo diario excedido";
                }
            }

            return respuestaGenerica;
        }
        #endregion
    }
}
