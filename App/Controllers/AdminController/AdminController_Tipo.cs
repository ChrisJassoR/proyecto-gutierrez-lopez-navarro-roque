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
        public async Task<IActionResult> Tipo(string nombre)
        {
            var tipos = await _tipoService.BuscarTipoAsync(nombre);
            var model = new TipoViewModel()
            {
                Tipos = tipos
            };
            return View(model);
        }
        public IActionResult BuscarTipo(string busqueda)
        {
            return RedirectToAction("Tipo", new {nombre = busqueda });
        }
        public async Task<IActionResult> AgregarTipo(Tipo NuevoTipo)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            var successful = await _tipoService.AgregarTipoAsync(NuevoTipo);
            if (!successful)
            {
                return BadRequest("No se pudo agregar Tipo");
            }
            return RedirectToAction("Tipo");
        }
    }
}