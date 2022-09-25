using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.BP.Data.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        public int Id { get; set; }
        [Required]
        public string Nombres { get; set; }
        public string Direccion { get; set; }
        [Required]
        public string Telefono { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public bool Estado { get; set; }
    }
}
