using App.BP.BLL.Interfaces;
using App.BP.Common.DTO;
using App.BP.Data.Models;
using App.BP.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace App.BP.BLL.BLL
{
    public class CuentaBLL : ICuentaBLL
    {
        private IRepository<Cuenta> _repository;

        public CuentaBLL(IRepository<Cuenta> repository)
        {
            _repository = repository;
        }

        #region Public Methods
        public async Task<Cuenta> CrearCuentaAsync(Cuenta cuenta)
        {
            await _repository.CreateEntityAsync(cuenta);
            await _repository.SaveAsync();
            return cuenta;
        }

        public async Task<Cuenta> EditarCuentaAsync(Cuenta cuenta)
        {
            Cuenta cuentaOriginal = await _repository.GetEntityByIdAsync(cuenta.Id);

            cuentaOriginal.Tipo = cuenta.Tipo;
            cuentaOriginal.NumeroCuenta = cuenta.NumeroCuenta;
            cuentaOriginal.Estado = cuenta.Estado;
            cuentaOriginal.SaldoInicial = cuenta.SaldoInicial;

            await _repository.UpdateEntityAsync(cuentaOriginal);
            await _repository.SaveAsync();

            return cuenta;
        }

        public async Task EliminarCuentaAsync(int id)
        {
            await _repository.DeleteEntityAsync(id);
            await _repository.SaveAsync();
        }

        public async Task<List<Cuenta>> ObtenerCuentasAsync()
        {
            var query = await _repository.GetAllAsync();

            List<Cuenta> cuentas = await query.ToListAsync();
            return cuentas;
        }
        #endregion

    }
}
