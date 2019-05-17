using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Data;
using App.Models.DataBaseModel;
using Microsoft.EntityFrameworkCore;
namespace App.Services
{
    public class ActividadService : IActividadService
    {
        private readonly ApplicationDbContext _context;
        public ActividadService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Actividad[]> GetIncompleteItemsAsync()
        {
            return await _context.Actividades
                .ToArrayAsync();
        }
    }
}

