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
        public IActionResult Alumno()
        {
            return View();
        }
        public IActionResult Profesor()
        {
            return View();
        }

        public IActionResult Carrera()
        {
            return View();
        }
        public IActionResult Materia()
        {
            return View();
        }
        public IActionResult Tipo()
        {
            return View();
        }
        public IActionResult Competencia()
        {
            return View();
        }public IActionResult Curso()
        {
            return View();
        }
        public IActionResult Ciclo()
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