using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using App.Models;
namespace App.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Hoja_de_cotejo()
        {
            return View();
        }
        public IActionResult Calificación()
        {
            return View();
        }

        public IActionResult Actividad_Alumno()
        {
            return View();
        }
        public IActionResult Alumno_Calificación()
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