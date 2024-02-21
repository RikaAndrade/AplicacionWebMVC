using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
namespace AplicacionWebMVC.Models
{
    [Table("Dueños")]
    public class Dueño
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nombre { get; set; }  

        public int Edad {  get; set; }

        public string Telefono {  get; set; }

        public string Direccion {  get; set; }

    }
}
