using ConsumirAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ConsumirAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



        //pureba para llamar a la vista 
        public IActionResult Indexn()
        {
            return View("~/Views/Shared/_Layout1.cshtml");
        }

    }
}
