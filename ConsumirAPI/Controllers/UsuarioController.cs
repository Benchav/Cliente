using ConsumirAPI.Models;
using ConsumirAPI.Servicios;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ConsumirAPI.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IServicesAPI _servicesAPI;

        public UsuarioController(IServicesAPI servicioAPI)
        {
            _servicesAPI = servicioAPI;
        }
        public IActionResult CrearUs()
        {
            return View();
        }

        public async Task<IActionResult> ObtenerUs()
        {
            List<ModeloUsuario> lista = await _servicesAPI.ListaUs();

            return Json(new { data = lista });
        }


        public async Task<IActionResult> GuardarUs(ModeloUsuario ObjU)
        {
            bool respuesta = false;


            if (ObjU.Id == Guid.Empty)
            {

                respuesta = await _servicesAPI.InsertarUs(ObjU);
            }
            else
            {
                respuesta = await _servicesAPI.EditarUs(ObjU);
            }
            return Json(new { resultado = respuesta });
        }

        public async Task<IActionResult> EliminaUs(Guid Id)
        {
            bool respuesta = false;

            Console.WriteLine(Id);

            if (Id != Guid.Empty)
            {

                respuesta = await _servicesAPI.DeleteUs(Id);
            }

            return Json(new { resultado = respuesta });
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
