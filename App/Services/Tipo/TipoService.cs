using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Data;
using App.Models.DataBaseModel;
using Microsoft.EntityFrameworkCore;
namespace App.Services
{
    public class TipoService : ITipoService
    {
        private readonly ApplicationDbContext _context;
        public TipoService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Tipo[]> GetIncompleteItemsAsync()
        {
            return await _context.Tipos
                .ToArrayAsync();
        }
        public async Task<bool> AgregarTipoAsync (Tipo NuevoTipo)
        {
            _context.Tipos.Add(NuevoTipo);
            var saveResult = await _context.SaveChangesAsync();
            return saveResult==1;
        }
    }
}