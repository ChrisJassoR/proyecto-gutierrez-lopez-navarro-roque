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
        public async Task<IActionResult> Materia(string nombre)
        {
            var materias = await _materiaService.BuscarMateriaAsync(nombre);
            var model = new MateriaViewModel()
            {
                Materias = materias
            };
            return View(model);
        }
        public IActionResult BuscarMateria(string busqueda)
        {
            return RedirectToAction("Materia", new { nombre = busqueda});
        }
        public async Task<IActionResult> AgregarMateria(Materia NuevoMateria)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            var successful = await _materiaService.AgregarMateriaAsync(NuevoMateria);
            if (!successful)
            {
                return BadRequest("No se pudo agregar Materia");
            }
            return RedirectToAction("Materia");
        }
    }
}