using ConsumirAPI.Models;
using ConsumirAPI.Servicios;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ConsumirAPI.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly IServicesAPI _servicesAPI;

        public CategoriaController(IServicesAPI servicioAPI)
        {
            _servicesAPI = servicioAPI;
        }
        public IActionResult Crear()
        {
            return View();
        }

        public async Task<IActionResult> Obtener()
        {
            List<ModeloCategoria> lista = await _servicesAPI.Lista();

            return Json(new { data = lista });
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId= Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
