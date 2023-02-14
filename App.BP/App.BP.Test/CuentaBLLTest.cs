using App.BP.BLL.BLL;
using App.BP.BLL.Interfaces;
using App.BP.Common.DTO;
using App.BP.Repository.Interfaces;
using NSubstitute;
using NUnit.Framework;

namespace App.BP.Test
{
    public class CuentaBLLTest
    {
        [SetUp]
        public void Setup()
        {
        }

        //[Test]
        //public async Task CrearMovimientoAsync_TipoEsCredito_CrearRegistro()
        //{
        //    //Arrange
        //    var _repositoryCliente = Substitute.For<IRepository<Cliente>>();
        //    var _repositoryPersona = Substitute.For<IRepository<Persona>>();
        //    var _repositoryCuenta = Substitute.For<IRepository<Cuenta>>();
        //    ICuentaBLL movimientoBll = new CuentaBLL(_repositoryCuenta, _repositoryPersona, _repositoryCliente);

        //    MovimientoEfectuado movimientoEfectuado = new MovimientoEfectuado
        //    {
        //        Tipo = "Credito",
        //        CuentaId = 1,
        //        CantidadMovimiento = 20
        //    };

        //    //Act
        //    var result = await movimientoBll.CrearCuentaClienteAsync(new CuentaAhorroDTO { });
            
        //    //Assert
        //    Assert.IsNotNull(result);
        //}

   
    }
}