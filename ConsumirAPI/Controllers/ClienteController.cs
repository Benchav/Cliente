using ConsumirAPI.Models;
using ConsumirAPI.Servicios;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ConsumirAPI.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IServicesAPI _servicesAPI;

        public ClienteController(IServicesAPI servicioAPI)
        {
            _servicesAPI = servicioAPI;
        }
        public IActionResult CrearC()
        {
            return View();
        }

        public async Task<IActionResult> ObtenerC()
        {
            List<ModeloCliente> lista = await _servicesAPI.ListarC();

            return Json(new { data = lista });
        }


        public async Task<IActionResult> GuardarC(ModeloCliente ObjCat)
        {
            bool respuesta = false;

            //      Console.WriteLine(ObjCat);

            if (ObjCat.Id == Guid.Empty)
            {

                respuesta = await _servicesAPI.InsertarC(ObjCat);
            }
            else
            {
                respuesta = await _servicesAPI.EditarC(ObjCat);
            }
            return Json(new { resultado = respuesta });
        }

        public async Task<IActionResult> EliminarC(Guid Id)
        {
            bool respuesta = false;

            Console.WriteLine(Id);

            if (Id != Guid.Empty)
            {

                respuesta = await _servicesAPI.DeleteC(Id);
            }

            return Json(new { resultado = respuesta });
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
