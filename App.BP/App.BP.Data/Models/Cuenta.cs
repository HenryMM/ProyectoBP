using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.BP.Data.Models
{
    [Table("Cuenta")]
    public class Cuenta
    {
        public int Id { get; set; }
        [Required]
        public string NumeroCuenta { get; set; }
        [Required]
        public string Tipo { get; set; }
        [Required]
        public int SaldoInicial { get; set; }
        [Required]
        public bool Estado { get; set; }
        [Required]
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public List<Movimiento> Movimientos { get; set; }
    }
}
