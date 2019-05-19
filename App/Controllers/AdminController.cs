﻿using System;
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
        private string ALUMNO { get; set; }
        private string PROFESOR { get; set; }
        private string CARRERA { get; set; }
        private string MATERIA { get; set; }
        private string TIPO { get; set; }
        private string COMPETENCIA { get; set; }
        private int CURSO { get; set; }
        private string CICLO { get; set; }

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

        public async Task<IActionResult> Alumno()
        {
            var alumnos = await _alumnoService.BuscarAlumnoAsync(ALUMNO);
            var model = new AlumnoViewModel()
            {
                Alumnos = alumnos
            };
            return View(model);
        }
        public IActionResult BuscarAlumno(string nombre)
        {
            ALUMNO = nombre;
            return RedirectToAction("Alumno");
        }
        public async Task<IActionResult> AgregarAlumno(Alumno NuevoAlumno)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            var successful = await _alumnoService.AgregarAlumnoAsync(NuevoAlumno);
            if (!successful)
            {
                return BadRequest("No se pudo agregar alumno");
            }
            return RedirectToAction("Alumno");
        }

        public async Task<IActionResult> Profesor()
        {
            var profesores = await _profesorService.BuscarProfesorAsync(PROFESOR);
            var model = new ProfesorViewModel()
            {
                Profesores = profesores
            };
            return View(model);
        }
        public IActionResult BuscarProfesor(string nombre)
        {
            PROFESOR = nombre;
            return RedirectToAction("Profesor");
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

        public async Task<IActionResult> Carrera()
        {
            var carreras = await _carreraService.BuscarCarreraAsync(CARRERA);
            var model = new CarreraViewModel()
            {
                Carreras = carreras
            };
            return View(model);
        }
        public IActionResult BuscarCarrera(string nombre)
        {
            CARRERA = nombre;
            return RedirectToAction("Carrera");
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

        public async Task<IActionResult> Materia()
        {
            var materias = await _materiaService.BuscarMateriaAsync(MATERIA);
            var model = new MateriaViewModel()
            {
                Materias = materias
            };
            return View(model);
        }
        public IActionResult BuscarMateria(string nombre)
        {
            MATERIA = nombre;
            return RedirectToAction("Materia");
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

        public async Task<IActionResult> Tipo()
        {
            var tipos = await _tipoService.BuscarTipoAsync(TIPO);
            var model = new TipoViewModel()
            {
                Tipos = tipos
            };
            return View(model);
        }
        public IActionResult BuscarTipo(string nombre)
        {
            TIPO = nombre;
            return RedirectToAction("Tipo");
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

        public async Task<IActionResult> Competencia()
        {
            var competencias = await _competenciaService.BuscarCompetenciaAsync(COMPETENCIA);
            var model = new CompetenciaViewModel()
            {
                Competencias = competencias
            };
            return View(model);
        }
        public IActionResult BuscarCompetenica(string nombre)
        {
            COMPETENCIA = nombre;
            return RedirectToAction("Competenicia");
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

        public async Task<IActionResult> Curso()
        {
            var cursos = await _cursoService.BuscarCursoAsync(CURSO);
            var model = new CursoViewModel()
            {
                Cursos = cursos
            };
            return View(model);
        }
        public IActionResult BuscarCurso(int nombre)
        {
            CURSO = nombre;
            return RedirectToAction("Curso");
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

        public async Task<IActionResult> Ciclo()
        {
            var ciclos = await _cicloService.BuscarCicloAsync(CICLO);
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