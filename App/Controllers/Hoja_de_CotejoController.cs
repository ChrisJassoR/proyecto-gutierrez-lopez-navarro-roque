using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using App.Models;
using App.Models.ViewModels;
using App.Services;
using Microsoft.AspNetCore.Authorization;

namespace App.Controllers
{
    public class Hoja_de_CotejoController : Controller
    {
        public readonly ICalificacionService _calificacionService;
        public readonly IActividadService _actividadService;
        public readonly ICursoActividadService _cursoActividadService;
        public readonly IActividadAlumnoService _actividadAlumnoService;
        public readonly ITrabajoService _trabajoService;
        public readonly ICursoService _cursoService;
        private int CURSO { get; set; }
        public Hoja_de_CotejoController (   ICalificacionService calificacionService,
                                            IActividadService actividadService,
                                            ICursoActividadService cursoActividadService,
                                            IActividadAlumnoService actividadAlumnoService,
                                            ITrabajoService trabajoService,
                                            ICursoService cursoService)
        {
            _calificacionService = calificacionService;
            _actividadService = actividadService;
            _cursoActividadService = cursoActividadService;
            _actividadAlumnoService = actividadAlumnoService;
            _trabajoService = trabajoService;
            _cursoService = cursoService;
        }
        //aparecen los cursos en los que esta el alumno //filtrar por el usuario
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var cursos = await _cursoService.BuscarCursoAsync(CURSO);
            var model = new CursoViewModel()
            {
                Cursos = cursos
            };
            return View(model);
        }
        //aparecen las actividades del curso al que esta
        public async Task<IActionResult> Hoja_de_Cotejo()
        {
            var actividadAlumnos = await _actividadAlumnoService.GetIncompleteItemsAsync();
            var model = new ActividadAlumnoViewModel()
            {
                ActividadAlumnos = actividadAlumnos
            };
            return View(model);
        }
        //aparecen las calificaciones de los cursos
        public async Task<IActionResult> Calificacion()
        {
            var calificaciones = await _calificacionService.GetIncompleteItemsAsync();
            var model = new CalificacionViewModel()
            {
                Calificaciones = calificaciones
            };
            return View(model);
        }
        //aparece la misma actividad con los distintos alumnos
        public async Task<IActionResult> Alumno_Calificacion()
        {
            var actividadAlumnos = await _actividadAlumnoService.GetIncompleteItemsAsync();
            var model = new ActividadAlumnoViewModel()
            {
                ActividadAlumnos = actividadAlumnos 
            };
            return View(model);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}