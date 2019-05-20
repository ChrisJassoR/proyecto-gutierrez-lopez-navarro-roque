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
        public async Task<IActionResult> Competencia(string nombre)
        {
            var competencias = await _competenciaService.BuscarCompetenciaAsync(nombre);
            var model = new CompetenciaViewModel()
            {
                Competencias = competencias
            };
            return View(model);
        }
        public IActionResult BuscarCompetenica(string busqueda)
        {
            return RedirectToAction("Competenicia", new {nombre = busqueda});
        }
        public async Task<IActionResult> AgregarCompetencia(Competencia NuevoCompetencia)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Competencia");
            }
            var successful = await _competenciaService.AgregarCompetenciaAsync(NuevoCompetencia);
            if (!successful)
            {
                return BadRequest("No se pudo agregar competencia");
            }
            return RedirectToAction("Index");
        }
    }
}