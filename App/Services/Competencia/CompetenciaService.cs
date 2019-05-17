using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Data;
using App.Models.DataBaseModel;
using Microsoft.EntityFrameworkCore;
namespace App.Services
{
    public class CompetenciaService : ICompetenciaService
    {
        private readonly ApplicationDbContext _context;
        public CompetenciaService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Competencia[]> GetIncompleteItemsAsync()
        {
            return await _context.Competencias
                .ToArrayAsync();
        }
    }
}