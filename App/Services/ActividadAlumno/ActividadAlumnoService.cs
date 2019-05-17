using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Data;
using App.Models.DataBaseModel;
using Microsoft.EntityFrameworkCore;
namespace App.Services
{
    public class ActividadAlumnoService : IActividadAlumnoService
    {
        private readonly ApplicationDbContext _context;
        public ActividadAlumnoService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<ActividadAlumno[]> GetIncompleteItemsAsync()
        {
            return await _context.ActividadAlumnos
                .ToArrayAsync();
        }
    }
}