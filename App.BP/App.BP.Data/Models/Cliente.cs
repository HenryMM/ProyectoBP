using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace App.BP.Data.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        public Cliente()
        {
            Cuentas = new HashSet<Cuenta>();
        }
        public int Id { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public bool Estado { get; set; }
        [Required]
        public int PersonaId { get; set; }
        public ICollection<Cuenta> Cuentas { get; set; }
    }
}
