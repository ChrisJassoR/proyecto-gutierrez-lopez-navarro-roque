using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using App.Models;
using App.Models.DataBaseModel;
using App.Models.ViewModels;
using App.Services;
using Microsoft.AspNetCore.Authorization;

namespace App.Controllers.AdminController
{
    public partial class AdminController : Controller
    {
        public async Task<IActionResult> Carrera(string nombre)
        {
            var carreras = await _carreraService.BuscarCarreraAsync(nombre);
            var model = new CarreraViewModel()
            {
                Carreras = carreras
            };
            return View(model);
        }
        public IActionResult BuscarCarrera(string busqueda)
        {
            return RedirectToAction("Carrera", new { nombre = busqueda});
        }
        public async Task<IActionResult> AgregarCarrera(Carrera NuevoCarrera)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            var successful = await _carreraService.AgregarCarreraAsync(NuevoCarrera);
            if (!successful)
            {
                return BadRequest("No se pudo agregar carrera");
            }
            return RedirectToAction("Carrera");
        }
    }
}