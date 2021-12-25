using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExameTeste.Data;
using ExameTeste.Models;

namespace ExameTeste.Controllers
{
    public class FaixaEtariasController : Controller
    {
        private readonly ExameTesteContext _context;

        public FaixaEtariasController(ExameTesteContext context)
        {
            _context = context;
        }

        // GET: FaixaEtarias
        public async Task<IActionResult> Index()
        {
            return View(await _context.FaixaEtaria.ToListAsync());
        }

        // GET: FaixaEtarias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var faixaEtaria = await _context.FaixaEtaria
                .FirstOrDefaultAsync(m => m.Id == id);
            if (faixaEtaria == null)
            {
                return NotFound();
            }

            return View(faixaEtaria);
        }

        // GET: FaixaEtarias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FaixaEtarias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Classificação")] FaixaEtaria faixaEtaria)
        {
            if (ModelState.IsValid)
            {
                _context.Add(faixaEtaria);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(faixaEtaria);
        }

        // GET: FaixaEtarias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var faixaEtaria = await _context.FaixaEtaria.FindAsync(id);
            if (faixaEtaria == null)
            {
                return NotFound();
            }
            return View(faixaEtaria);
        }

        // POST: FaixaEtarias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Classificação")] FaixaEtaria faixaEtaria)
        {
            if (id != faixaEtaria.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(faixaEtaria);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FaixaEtariaExists(faixaEtaria.Id))
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
            return View(faixaEtaria);
        }

        // GET: FaixaEtarias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var faixaEtaria = await _context.FaixaEtaria
                .FirstOrDefaultAsync(m => m.Id == id);
            if (faixaEtaria == null)
            {
                return NotFound();
            }

            return View(faixaEtaria);
        }

        // POST: FaixaEtarias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var faixaEtaria = await _context.FaixaEtaria.FindAsync(id);
            _context.FaixaEtaria.Remove(faixaEtaria);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FaixaEtariaExists(int id)
        {
            return _context.FaixaEtaria.Any(e => e.Id == id);
        }
    }
}
