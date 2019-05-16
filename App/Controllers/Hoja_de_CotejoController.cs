using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using App.Models;
using Microsoft.AspNetCore.Authorization;

namespace App.Controllers
{
    public class Hoja_de_CotejoController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Hoja_de_Cotejo()
        {
            return View();
        }
        public IActionResult Calificacion()
        {
            return View();
        }

        public IActionResult Actividad_Alumno()
        {
            return View();
        }
        public IActionResult Alumno_Calificacion()
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