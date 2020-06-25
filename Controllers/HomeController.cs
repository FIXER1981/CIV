using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CIV.Models;

namespace CIV.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult InicioSesion()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ValeIngresar()
        {
            return View();
        }
        public IActionResult ValeEstatus()
        {
            return View();
        }
        public IActionResult InventarioIngresar()
        {
            return View();
        }
        public IActionResult InventarioEstatus()
        {
            return View();
        }
        public IActionResult Reporte()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
