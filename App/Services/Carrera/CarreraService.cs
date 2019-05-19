using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Data;
using App.Models.DataBaseModel;
using Microsoft.EntityFrameworkCore;
namespace App.Services
{
    public class CarreraService : ICarreraService
    {
        private readonly ApplicationDbContext _context;
        public CarreraService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Carrera[]> BuscarCarreraAsync(string nombre)
        {
            return await _context.Carreras
                .Where (x => x.nombre.Contains(nombre))
                .ToArrayAsync();
        }
        public async Task<bool> AgregarCarreraAsync (Carrera NuevoCarrera)
        {
            _context.Carreras.Add(NuevoCarrera);
            var saveResult = await _context.SaveChangesAsync();
            return saveResult==1;
        }
    }
}