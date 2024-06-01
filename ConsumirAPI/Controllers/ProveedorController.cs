using ConsumirAPI.Models;
using ConsumirAPI.Servicios;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ConsumirAPI.Controllers
{
    public class ProveedorController : Controller
    {
        private readonly IServicesAPI _servicesAPI;

        public ProveedorController(IServicesAPI servicioAPI)
        {
            _servicesAPI = servicioAPI;
        }
        public IActionResult CrearP()
        {
            return View();
        }

        public async Task<IActionResult> ObtenerP()
        {
            List<ModeloProveedor> lista = await _servicesAPI.ListarP();

            return Json(new { data = lista });
        }


        public async Task<IActionResult> GuardarP(ModeloProveedor ObjCat)
        {
            bool respuesta = false;

            //      Console.WriteLine(ObjCat);

            if (ObjCat.Id == Guid.Empty)
            {

                respuesta = await _servicesAPI.InsertarP(ObjCat);
            }
            else
            {
                respuesta = await _servicesAPI.EditarP(ObjCat);
            }
            return Json(new { resultado = respuesta });
        }

        public async Task<IActionResult> EliminarP(Guid Id)
        {
            bool respuesta = false;

            Console.WriteLine(Id);

            if (Id != Guid.Empty)
            {

                respuesta = await _servicesAPI.DeleteP(Id);
            }

            return Json(new { resultado = respuesta });
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
