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
                new ModeloProducto { Id = 1, Nombre = "Mantequilla", Descripcion = "libra", Precio = 25.00m },
                new ModeloProducto { Id = 2, Nombre = "Arina", Descripcion = "saco de arina", Precio = 300.00m },
                new ModeloProducto { Id = 3, Nombre = "Azucar", Descripcion = "libra", Precio = 30.00m },
                new ModeloProducto { Id = 4, Nombre = "Levadura", Descripcion = "libra", Precio = 24.00m },
                new ModeloProducto { Id = 5, Nombre = "Colorante", Descripcion = "litro", Precio = 50.00m },
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

