using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.BP.Data.Models
{
    [Table("Persona")]
    public class Persona
    {
        public int Id { get; set; }
        [Required]
        public string Nombres { get; set; }
        [Required]
        public string Direccion { get; set; }
        [Required]
        public string Telefono { get; set; }
        [Required]
        public string Genero { get; set; }
        [Required]
        public string Identificacion { get; set; }
        public Nullable<DateTime> FechaNacimiento { get; set; }
    }
}
