using System.ComponentModel.DataAnnotations;

namespace ConsumirAPI.Models
{
    public class ModeloRol: BaseEntity
    {
        //[Required(ErrorMessage = "La Descripcion es obligatorio.")]
        public string Descripcion { get; set; }

        //[Required(ErrorMessage = "La fecha de creacion es obligatorio.")]
        public DateTime FechaCreacion { get; set; }
    }
}
