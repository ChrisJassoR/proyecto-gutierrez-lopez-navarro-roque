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

namespace App.Controllers
{
    //[Authorize(Roles = "Administrator")]
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
        public AdminController(IAlumnoService alumnoService,
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
        public async Task<IActionResult> ModificarAlumno(int alumnoIdAnterior, Alumno ModificarAlumno)
        {
            if (!ModelState.IsValid)
                return RedirectToAction("Index");
            var successful = await _alumnoService.ModificarAlumnoAsync(alumnoIdAnterior, ModificarAlumno);
            if (!successful)
                return BadRequest("No se pudo modificacar alumno");
            return RedirectToAction("Alumno");

        }
        public async Task<IActionResult> EliminarAlumno(int alumnoId)
        {
            var successful = await _alumnoService.EliminarAlumnoAsync(alumnoId);
            if (!successful)
                return BadRequest("No se pudo eliminar alumno");
            return RedirectToAction("Alumno");
        }
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

        public async Task<IActionResult> Carrera(string nombre)
        {
            var carreras = await _carreraService.BuscarCarreraAsync(nombre);
            var model = new CarreraViewModel()
            {
                Carreras = carreras
            };
            return View(model);
        }
        public IActionResult BuscarCarrera(string busqueda)
        {
            return RedirectToAction("Carrera", new { nombre = busqueda});
        }
        public async Task<IActionResult> AgregarCarrera(Carrera NuevoCarrera)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            var successful = await _carreraService.AgregarCarreraAsync(NuevoCarrera);
            if (!successful)
            {
                return BadRequest("No se pudo agregar carrera");
            }
            return RedirectToAction("Carrera");
        }

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
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}