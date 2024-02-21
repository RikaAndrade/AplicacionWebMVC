using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
namespace AplicacionWebMVC.Models
{
    [Table("Mascotas")]
    public class Mascota
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Nombre { get; set; }

        public int ID_Dueño { get; set; } 

        public string Especie {  get; set; }

        public int Edad_Mascota { get; set; }
    }
}
