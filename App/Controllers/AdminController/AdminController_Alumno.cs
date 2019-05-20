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
        public async Task<IActionResult> Alumno(string busqueda)
        {
            var alumnos = await _alumnoService.BuscarAlumnoAsync(busqueda);
            var model = new AlumnoViewModel()
            {
                Alumnos = alumnos
            };
            return View(model);
        }
        public IActionResult BuscarAlumno(string nombre)
        {
            return RedirectToAction("Alumno", new{ busqueda = nombre});
        }
        public async Task<IActionResult> AgregarAlumno(Alumno NuevoAlumno)
        {
            if (!ModelState.IsValid)
                return RedirectToAction("Index");
            var successful = await _alumnoService.AgregarAlumnoAsync(NuevoAlumno);
            if (!successful)
                return BadRequest("No se pudo agregar alumno");
            return RedirectToAction("Alumno");
        }
        public async Task<IActionResult> ModificarAlumno(int alumnoId, string nombre)
        {
            if (!ModelState.IsValid)
                return RedirectToAction("Index");
            var successful = await _alumnoService.ModificarAlumnoAsync(alumnoId, nombre);
            if (!successful)
                return BadRequest("No se pudo modificar alumno");
            return RedirectToAction("Alumno");

        }
        public async Task<IActionResult> EliminarAlumno(int alumnoId)
        {
            var successful = await _alumnoService.EliminarAlumnoAsync(alumnoId);
            if (!successful)
                return BadRequest("No se pudo eliminar alumno");
            return RedirectToAction("Alumno");
        }
    }
}