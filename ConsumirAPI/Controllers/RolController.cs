using ConsumirAPI.Models;
using ConsumirAPI.Servicios;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ConsumirAPI.Controllers
{
    public class RolController : Controller
    {
        private readonly IServicesAPI _servicesAPI;

        public RolController(IServicesAPI servicioAPI)
        {
            _servicesAPI = servicioAPI;
        }
        public IActionResult CrearRol()
        {
            return View();
        }

        public async Task<IActionResult> ObtenerR()
        {
         
            List<ModeloRol> lista = await _servicesAPI.Listar();

            return Json(new { data = lista });
        }


        public async Task<IActionResult> GuardarR(ModeloRol ObjRol)
        {
            bool respuesta = false;

                //Console.WriteLine(ObjRol);

            if (ObjRol.Id == Guid.Empty)
            {

                respuesta = await _servicesAPI.InsertarR(ObjRol);
            }
            else
            {
                respuesta = await _servicesAPI.EditarRol(ObjRol);
            }
            return Json(new { resultado = respuesta });
        }

        public async Task<IActionResult> EliminarR(Guid Id)
        {
            bool respuesta = false;

            Console.WriteLine(Id);

            if (Id != Guid.Empty)
            {

                respuesta = await _servicesAPI.DeleteR(Id);
            }

            return Json(new { resultado = respuesta });
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
