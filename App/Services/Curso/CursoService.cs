using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Data;
using App.Models.DataBaseModel;
using Microsoft.EntityFrameworkCore;
namespace App.Services
{
    public class CursoService : ICursoService
    {
        private readonly ApplicationDbContext _context;
        public CursoService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Curso[]> GetIncompleteItemsAsync()
        {
            return await _context.Cursos
                .ToArrayAsync();
        }
    }
}