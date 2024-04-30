namespace ConsumirAPI.Models
{
    public class ModeloCategoria : BaseEntity
    {

        public string Descripcion { get; set; }

        public bool Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
