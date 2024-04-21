namespace ConsumirAPI.Models
{
    public class ModCategoria : BaseEntity
    {
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
