using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.BP.Data.Models
{
    [Table("Movimiento")]
    public class Movimiento
    {
        public int Id { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        [Required]
        public int MovimientoRealizado { get; set; }
        [Required]
        public int SaldoInicial { get; set; }
        [Required]
        public int SaldoDisponible { get; set; }
        [Required]
        public bool Estado { get; set; }
        [Required]
        public string Tipo { get; set; }
        [Required]
        public int CuentaId { get; set; }
        public Cuenta Cuenta { get; set; }

    }
}
