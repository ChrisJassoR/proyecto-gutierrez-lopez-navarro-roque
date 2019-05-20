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
        public async Task<IActionResult> Profesor(string nombre)
        {
            var profesores = await _profesorService.BuscarProfesorAsync(nombre);
            var model = new ProfesorViewModel()
            {
                Profesores = profesores
            };
            return View(model);
        }
        public IActionResult BuscarProfesor(string busqueda)
        {
            return RedirectToAction("Profesor", new{nombre = busqueda});
        }
        public async Task<IActionResult> AgregarProfesor(Profesor NuevoProfesor)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            var successful = await _profesorService.AgregarProfesorAsync(NuevoProfesor);
            if (!successful)
            {
                return BadRequest("No se pudo agregar profesor");
            }
            return RedirectToAction("Profesor");
        }
    }
}