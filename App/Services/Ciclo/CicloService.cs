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
        public async Task<Ciclo[]> GetIncompleteItemsAsync()
        {
            return await _context.Ciclos
                .ToArrayAsync();
        }
    }
}