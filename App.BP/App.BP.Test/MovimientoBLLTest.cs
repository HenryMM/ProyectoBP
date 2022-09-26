using App.BP.BLL.BLL;
using App.BP.BLL.Interfaces;
using App.BP.Common.DTO;
using App.BP.Data;
using App.BP.Data.Models;
using App.BP.Repository.Interfaces;
using App.BP.Repository.Repositories;
using Microsoft.EntityFrameworkCore;
using Moq;
using NSubstitute;
using System.Reflection.Metadata;

namespace App.BP.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task CrearMovimientoAsync_TipoEsCredito_CrearRegistro()
        {
            //Arrange
            var _repositoryMovimiento = Substitute.For<IRepository<Movimiento>>();
            var _repositoryCuenta = Substitute.For<IRepository<Cuenta>>();
            IMovimientoBLL movimientoBll = new MovimientoBLL(_repositoryMovimiento, _repositoryCuenta);

            MovimientoEfectuado movimientoEfectuado = new MovimientoEfectuado
            {
                Tipo = "Credito",
                CuentaId = 1,
                CantidadMovimiento = 20
            };

            //Act
            var result = await movimientoBll.CrearMovimientoAsync(movimientoEfectuado);
            
            //Assert
            Assert.IsNotNull(result.Data);
        }

        [Test]
        public async Task CrearMovimientoAsync_SaldoEsCero_NoCrearRegistro()
        {
            //Arrange
            var _repositoryMovimiento = Substitute.For<IRepository<Movimiento>>();
            var _repositoryCuenta = Substitute.For<IRepository<Cuenta>>();
            IMovimientoBLL movimientoBll = new MovimientoBLL(_repositoryMovimiento, _repositoryCuenta);

            MovimientoEfectuado movimientoEfectuado = new MovimientoEfectuado
            {
                Tipo = "Credito",
                CuentaId = 1,
                CantidadMovimiento = 20
            };

            //Act
            var result = await movimientoBll.CrearMovimientoAsync(movimientoEfectuado);

            //Assert
            Assert.Equals(result.Mensaje,"Saldo Insuficiente");
        }
    }
}