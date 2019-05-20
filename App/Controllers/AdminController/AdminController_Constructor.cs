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
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}