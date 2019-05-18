using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Data;
using App.Models.DataBaseModel;
using Microsoft.EntityFrameworkCore;
namespace App.Services
{
    public class ProfesorService : IProfesorService
    {
        private readonly ApplicationDbContext _context;
        public ProfesorService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Profesor[]> GetIncompleteItemsAsync()
        {
            return await _context.Profesores
                .ToArrayAsync();
        }
        public async Task<bool> AgregarProfesorAsync (Profesor NuevoProfesor)
        {
            _context.Profesores.Add(NuevoProfesor);
            var saveResult = await _context.SaveChangesAsync();
            return saveResult==1;
        }
    }
}