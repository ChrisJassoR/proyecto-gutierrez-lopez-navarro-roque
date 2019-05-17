using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Data;
using App.Models.DataBaseModel;
using Microsoft.EntityFrameworkCore;
namespace App.Services
{
    public class TrabajoService : ITrabajoService
    {
        private readonly ApplicationDbContext _context;
        public TrabajoService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Trabajo[]> GetIncompleteItemsAsync()
        {
            return await _context.Trabajos
                .ToArrayAsync();
        }
    }
}