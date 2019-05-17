using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Data;
using App.Models.DataBaseModel;
using Microsoft.EntityFrameworkCore;
namespace App.Services
{
    public class CursoActividadService : ICursoActividadService
    {
        private readonly ApplicationDbContext _context;
        public CursoActividadService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<CursoActividad[]> GetIncompleteItemsAsync()
        {
            return await _context.CursoActividades
                .ToArrayAsync();
        }
    }
}