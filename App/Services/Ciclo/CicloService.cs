using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Data;
using App.Models.DataBaseModel;
using Microsoft.EntityFrameworkCore;
namespace App.Services
{
    public class CicloService : ICicloService
    {
        private readonly ApplicationDbContext _context;
        public CicloService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Ciclo[]> BuscarCicloAsync(string nombre)
        {
            return await _context.Ciclos
                .Where(x => x.cicloClave.Contains(nombre))
                .ToArrayAsync();
        }
        public async Task<bool> AgregarCicloAsync (Ciclo NuevoCiclo)
        {
            _context.Ciclos.Add(NuevoCiclo);
            var saveResult = await _context.SaveChangesAsync();
            return saveResult==1;
        }
    }
}