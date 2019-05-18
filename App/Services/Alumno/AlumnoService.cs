using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Data;
using App.Models.DataBaseModel;
using Microsoft.EntityFrameworkCore;
namespace App.Services
{
    public class AlumnoService : IAlumnoService
    {
        private readonly ApplicationDbContext _context;
        public AlumnoService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Alumno[]> GetIncompleteItemsAsync()
        {
            return await _context.Alumnos
                .ToArrayAsync();
        }
        public async Task<bool> AgregarAlumnoAsync (Alumno NuevoAlumno)
        {
            _context.Alumnos.Add(NuevoAlumno);
            var saveResult = await _context.SaveChangesAsync();
            return saveResult==1;
        }
        
    }
}