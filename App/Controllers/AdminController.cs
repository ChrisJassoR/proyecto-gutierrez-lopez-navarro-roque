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
        public IActionResult Index()
        {
            return View();
        }

        private readonly IAlumnoService _alumnoService;
        public AdminController(IAlumnoService alumnoService)
        {
            _alumnoService = alumnoService;
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
        /*
        private readonly IProfesorService _profesorService;
       
        public AdminController(IProfesorService profesorService)
        {
            _profesorService = profesorService;
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

        private readonly ICarreraService _carreraService;
      
        public AdminController(ICarreraService carreraService)
        {
            _carreraService = carreraService;
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

        private readonly IMateriaService _materiaService;
         
        public AdminController(IMateriaService materiaService)
        {
            _materiaService = materiaService;
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

        private readonly ITipoService _tipoService;
        
        public AdminController(ITipoService tipoService)
        {
            _tipoService = tipoService;
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

        private readonly ICompetenciaService _competenciaService;
       
        public AdminController(ICompetenciaService competenciaService)
        {
            _competenciaService = competenciaService;
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

        private readonly ICursoService _cursoService;
       
        public AdminController(ICursoService cursoService)
        {
            _cursoService = cursoService;
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

        private readonly ICicloService _cicloService;
        public AdminController(ICicloService cicloService)
        {
            _cicloService = cicloService;
        }
        public async Task<IActionResult> Ciclo()
        {
            var ciclos = await _cicloService.GetIncompleteItemsAsync();
            var model = new CicloViewModel()
            {
               Ciclos = ciclos
            };
            return View(model);
        } */
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}