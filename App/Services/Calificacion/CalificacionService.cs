using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Data;
using App.Models.DataBaseModel;
using Microsoft.EntityFrameworkCore;
namespace App.Services
{
    public class CalificacionService : ICalificacionService
    {
        private readonly ApplicationDbContext _context;
        public CalificacionService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Calificacion[]> GetIncompleteItemsAsync()
        {
            return await _context.Calificaciones
                .ToArrayAsync();
        }
    }
}