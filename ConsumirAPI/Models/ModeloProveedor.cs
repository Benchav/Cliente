using System.ComponentModel.DataAnnotations;

namespace ConsumirAPI.Models
{
    public class ModeloProveedor : BaseEntity
    {
        public string NombreCompañia { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
