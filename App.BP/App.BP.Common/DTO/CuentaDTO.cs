
namespace App.BP.Common.DTO
{
    public class CuentaDTO
    {
        public int CuentaId { get; set; }
        public string NumeroCuenta { get; set; }
        public string Tipo { get; set; }
        public int SaldoActual { get; set; }
        public bool Estado { get; set; }
        public int ClienteId { get; set; }
        public string NombreCliente { get; set; }
    }
}
