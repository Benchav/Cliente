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


           public async Task<IActionResult> Guardar(ModeloCategoria ObjCat)
           {
               bool respuesta = false;
            
         //      Console.WriteLine(ObjCat);

               if (ObjCat.Id == Guid.Empty)
               {

                   respuesta = await _servicesAPI.Insertar(ObjCat);
               }
               else
               {
                   respuesta = await _servicesAPI.EditarCategorias(ObjCat);
               }
               return Json(new { resultado = respuesta });
           }

        public async Task<IActionResult> Eliminar(Guid Id)
        {
            bool respuesta = false;

            Console.WriteLine(Id);

            if (Id != Guid.Empty)
            {

                respuesta = await _servicesAPI.Delete(Id);
            }

            return Json(new { resultado = respuesta });
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId= Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
