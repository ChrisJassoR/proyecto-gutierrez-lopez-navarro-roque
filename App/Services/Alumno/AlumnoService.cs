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
        public async Task<Alumno[]> BuscarAlumnoAsync (string nombre)
        {
            return await _context.Alumnos
                .Where (x => x.nombre.Contains(nombre))
                .OrderBy (x => x.nombre)
                .ToArrayAsync();
        }
        public async Task<bool> AgregarAlumnoAsync (Alumno NuevoAlumno)
        {
            _context.Alumnos.Add(NuevoAlumno);
            //truena al repetir llave primaria
            var saveResult = await _context.SaveChangesAsync();
            return saveResult==1;
        }
        public async Task<bool> ModificarAlumnoAsync(int alumnoIdAnterior, Alumno ModificarAlumno)
        {
            var alumno = await _context.Alumnos
                .Where(x => x.alumnoId == alumnoIdAnterior)
                .SingleOrDefaultAsync();
                alumno = ModificarAlumno;
                var saveResult = await _context.SaveChangesAsync();
                return saveResult == 1;
        }
        public async Task<bool> EliminarAlumnoAsync (int alumnoId)
        {
            var alumno = await _context.Alumnos
                .Where(x => x.alumnoId == alumnoId)
                .SingleOrDefaultAsync();
                _context.Remove(alumno);
                var saveResult = await _context.SaveChangesAsync();
            return saveResult == 1;
        }
       
        
    }
}