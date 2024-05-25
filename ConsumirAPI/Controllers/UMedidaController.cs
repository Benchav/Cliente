using ConsumirAPI.Models;
using ConsumirAPI.Servicios;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ConsumirAPI.Controllers
{
    public class UMedidaController : Controller
    {
        private readonly IServicesAPI _servicesAPI;

        public UMedidaController(IServicesAPI servicioAPI)
        {
            _servicesAPI = servicioAPI;
        }
        public IActionResult CrearU()
        {
            return View();
        }

        public async Task<IActionResult> ObtenerU()
        {
            List<ModeloUMedida> lista = await _servicesAPI.ListaU();

            return Json(new { data = lista });
        }


        public async Task<IActionResult> GuardarU(ModeloUMedida ObjU)
        {
            bool respuesta = false;


            if (ObjU.Id == Guid.Empty)
            {

                respuesta = await _servicesAPI.InsertarU(ObjU);
            }
            else
            {
                respuesta = await _servicesAPI.EditarU(ObjU);
            }
            return Json(new { resultado = respuesta });
        }

        public async Task<IActionResult> EliminaU(Guid Id)
        {
            bool respuesta = false;

            Console.WriteLine(Id);

            if (Id != Guid.Empty)
            {

                respuesta = await _servicesAPI.DeleteU(Id);
            }

            return Json(new { resultado = respuesta });
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
