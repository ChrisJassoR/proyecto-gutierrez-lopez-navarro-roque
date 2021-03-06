using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using App.Data;
using App.Models.DataBaseModel;

namespace App.Controllers_AdminControllers
{
    public class TipoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TipoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Tipo
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tipos.ToListAsync());
        }

        // GET: Tipo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipo = await _context.Tipos
                .FirstOrDefaultAsync(m => m.tipoClave == id);
            if (tipo == null)
            {
                return NotFound();
            }

            return View(tipo);
        }

        // GET: Tipo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tipo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("tipoClave,nombre")] Tipo tipo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipo);
        }

        // GET: Tipo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipo = await _context.Tipos.FindAsync(id);
            if (tipo == null)
            {
                return NotFound();
            }
            return View(tipo);
        }

        // POST: Tipo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("tipoClave,nombre")] Tipo tipo)
        {
            if (id != tipo.tipoClave)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoExists(tipo.tipoClave))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(tipo);
        }

        // GET: Tipo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipo = await _context.Tipos
                .FirstOrDefaultAsync(m => m.tipoClave == id);
            if (tipo == null)
            {
                return NotFound();
            }

            return View(tipo);
        }

        // POST: Tipo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tipo = await _context.Tipos.FindAsync(id);
            _context.Tipos.Remove(tipo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoExists(int id)
        {
            return _context.Tipos.Any(e => e.tipoClave == id);
        }
    }
}
