using ConsumirAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConsumirAPI.Controllers
{
    public class FacturacionController : Controller
    {
        // Simulación de datos de productos
        private List<ModeloProducto> ObtenerProductos()
        {
            return new List<ModeloProducto>
            {
                new ModeloProducto { Id = 1, Nombre = "Mantequilla", Descripcion = "1 libra", Precio = 25.00m },
                new ModeloProducto { Id = 2, Nombre = "Arina", Descripcion = "1 saco de arina", Precio = 300.00m },
                new ModeloProducto { Id = 3, Nombre = "Azucar", Descripcion = "1 libra", Precio = 30.00m },
                new ModeloProducto { Id = 4, Nombre = "Levadura", Descripcion = "1 libra", Precio = 24.00m },
                new ModeloProducto { Id = 5, Nombre = "Sopa de Marisco", Descripcion = "rikitiksi", Precio = 108.00m },
                // Agrega más productos según sea necesario
            };
        }

        public ActionResult Index()
        {
            var productos = ObtenerProductos();
            return View(productos);
        }
    }
}

