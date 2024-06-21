namespace ConsumirAPI.Models
{
    public class ModeloDtProduct
    {


        //falta mapear el modelo producto, pero en el bak
        // no muestra los datos por que es secundario "SP"
        public Guid IdProducto { get; set; }
        public Guid IdMedida { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public string Marca { get; set; }

     //   public Producto objProducto { get; set; }
    }
}
