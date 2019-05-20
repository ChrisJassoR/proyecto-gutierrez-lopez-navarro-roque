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
        public async Task<IActionResult> Curso(int nombre)
        {
            var cursos = await _cursoService.BuscarCursoAsync(nombre);
            var model = new CursoViewModel()
            {
                Cursos = cursos
            };
            return View(model);
        }
        public IActionResult BuscarCurso(int busqueda)
        {
            return RedirectToAction("Curso", new{nombre = busqueda});
        }
        public async Task<IActionResult> AgregarCurso(Curso NuevoCurso)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            var successful = await _cursoService.AgregarCursoAsync(NuevoCurso);
            if (!successful)
            {
                return BadRequest("No se pudo agregar curso");
            }
            return RedirectToAction("Curso");
        }
    }
}