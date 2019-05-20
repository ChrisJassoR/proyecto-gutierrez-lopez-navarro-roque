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
        public async Task<IActionResult> Ciclo(string nombre)
        {
            var ciclos = await _cicloService.BuscarCicloAsync(nombre);
            var model = new CicloViewModel()
            {
                Ciclos = ciclos
            };
            return View(model);
        }
        public async Task<IActionResult> AgregarCiclo(Ciclo NuevoCiclo)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            var successful = await _cicloService.AgregarCicloAsync(NuevoCiclo);
            if (!successful)
            {
                return BadRequest("No se pudo agregar ciclo");
            }
            return RedirectToAction("Ciclo");
        }
        
    }
}