using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Data;
using App.Models.DataBaseModel;
using Microsoft.EntityFrameworkCore;
namespace App.Services
{
    public class MateriaService : IMateriaService
    {
        private readonly ApplicationDbContext _context;
        public MateriaService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Materia[]> BuscarMateriaAsync(string nombre)
        {
            return await _context.Materias
                .Where(x => x.Nombre.Contains(nombre))
                .ToArrayAsync();
        }
        public async Task<bool> AgregarMateriaAsync (Materia NuevoMateria)
        {
            _context.Materias.Add(NuevoMateria);
            var saveResult = await _context.SaveChangesAsync();
            return saveResult==1;
        }
    }
}