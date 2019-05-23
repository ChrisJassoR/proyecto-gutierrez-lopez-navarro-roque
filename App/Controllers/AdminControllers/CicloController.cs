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
    public class CicloController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CicloController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Ciclo
        public async Task<IActionResult> Index()
        {
            return View(await _context.Ciclos.ToListAsync());
        }

        // GET: Ciclo/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ciclo = await _context.Ciclos
                .FirstOrDefaultAsync(m => m.cicloClave == id);
            if (ciclo == null)
            {
                return NotFound();
            }

            return View(ciclo);
        }

        // GET: Ciclo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ciclo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("cicloClave,inicio,fin")] Ciclo ciclo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ciclo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ciclo);
        }

        // GET: Ciclo/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ciclo = await _context.Ciclos.FindAsync(id);
            if (ciclo == null)
            {
                return NotFound();
            }
            return View(ciclo);
        }

        // POST: Ciclo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("cicloClave,inicio,fin")] Ciclo ciclo)
        {
            if (id != ciclo.cicloClave)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ciclo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CicloExists(ciclo.cicloClave))
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
            return View(ciclo);
        }

        // GET: Ciclo/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ciclo = await _context.Ciclos
                .FirstOrDefaultAsync(m => m.cicloClave == id);
            if (ciclo == null)
            {
                return NotFound();
            }

            return View(ciclo);
        }

        // POST: Ciclo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var ciclo = await _context.Ciclos.FindAsync(id);
            _context.Ciclos.Remove(ciclo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CicloExists(string id)
        {
            return _context.Ciclos.Any(e => e.cicloClave == id);
        }
    }
}
