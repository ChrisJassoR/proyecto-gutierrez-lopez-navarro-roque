using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using App.Models;
using App.Models.ViewModels;
using App.Services;
namespace App.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAlumnoService _alumnoService;
        private readonly IProfesorService _profesorService;
        private readonly ICarreraService _carreraService;
        private readonly IMateriaService _materiaService;
        private readonly ITipoService _tipoService;
        private readonly ICompetenciaService _competenciaService;
        private readonly ICursoService _cursoService;
        private readonly ICicloService _cicloService;
        public AdminController( IAlumnoService alumnoService, 
                                IProfesorService profesorService,
                                ICarreraService carreraService, 
                                IMateriaService materiaService,
                                ITipoService tipoService,
                                ICompetenciaService competenciaService,
                                ICursoService cursoService,
                                ICicloService cicloService)
        {
            _alumnoService = alumnoService;
            _profesorService = profesorService;
            _carreraService = carreraService;
            _materiaService = materiaService;
            _tipoService = tipoService;
            _competenciaService = competenciaService;
            _cursoService = cursoService;
            _cicloService = cicloService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Alumno()
        {
            var alumnos = await _alumnoService.GetIncompleteItemsAsync();
            var model = new AlumnoViewModel()
            {
                Alumnos = alumnos
            };
            return View(model);
        }
        public async Task<IActionResult> Profesor()
        {
            var profesores = await _profesorService.GetIncompleteItemsAsync();
            var model = new ProfesorViewModel()
            {
                Profesores = profesores
            };
            return View(model);
        }
        public async Task<IActionResult> Carrera()
        {
            var carreras = await _carreraService.GetIncompleteItemsAsync();
            var model = new CarreraViewModel()
            {
               Carreras = carreras
            };
            return View(model);
        }
        public async Task<IActionResult> Materia()
        {
            var materias = await _materiaService.GetIncompleteItemsAsync();
            var model = new MateriaViewModel()
            {
                Materias = materias
            };
            return View(model);
        }
        public async Task<IActionResult> Tipo()
        {
            var tipos = await _tipoService.GetIncompleteItemsAsync();
            var model = new TipoViewModel()
            {
                Tipos = tipos
            };
            return View(model);
        }
        public async Task<IActionResult> Competencia()
        {
            var competencias = await _competenciaService.GetIncompleteItemsAsync();
            var model = new CompetenciaViewModel()
            {
                Competencias = competencias
            };
            return View(model);
        }
        public async Task<IActionResult> Curso()
        {
            var cursos = await _cursoService.GetIncompleteItemsAsync();
            var model = new CursoViewModel()
            {
                Cursos = cursos
            };
            return View(model);
        }
        public async Task<IActionResult> Ciclo()
        {
            var ciclos = await _cicloService.GetIncompleteItemsAsync();
            var model = new CicloViewModel()
            {
               Ciclos = ciclos
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