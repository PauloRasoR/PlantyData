using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PlentyData.Data;
using PlentyData.Models;

namespace PlentyData.Controllers
{
    public class TelefoneController : Controller
    {
        private readonly PlentyDataContext _context;

        public TelefoneController(PlentyDataContext context)
        {
            _context = context;
        }

        // GET: Telefone
        public async Task<IActionResult> Index()
        {
              return View(await _context.Telefone.ToListAsync());
        }

        // GET: Telefone/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Telefone == null)
            {
                return NotFound();
            }

            var telefone = await _context.Telefone
                .FirstOrDefaultAsync(m => m.Id == id);
            if (telefone == null)
            {
                return NotFound();
            }

            return View(telefone);
        }

        // GET: Telefone/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Telefone/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Tipo,NumeroTelefone,Ativo")] Telefone telefone)
        {
            if (ModelState.IsValid)
            {
                _context.Add(telefone);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(telefone);
        }

        // GET: Telefone/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Telefone == null)
            {
                return NotFound();
            }

            var telefone = await _context.Telefone.FindAsync(id);
            if (telefone == null)
            {
                return NotFound();
            }
            return View(telefone);
        }

        // POST: Telefone/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Tipo,NumeroTelefone,Ativo")] Telefone telefone)
        {
            if (id != telefone.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(telefone);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TelefoneExists(telefone.Id))
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
            return View(telefone);
        }

        // GET: Telefone/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Telefone == null)
            {
                return NotFound();
            }

            var telefone = await _context.Telefone
                .FirstOrDefaultAsync(m => m.Id == id);
            if (telefone == null)
            {
                return NotFound();
            }

            return View(telefone);
        }

        // POST: Telefone/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Telefone == null)
            {
                return Problem("Entity set 'PlentyDataContext.Telefone'  is null.");
            }
            var telefone = await _context.Telefone.FindAsync(id);
            if (telefone != null)
            {
                _context.Telefone.Remove(telefone);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TelefoneExists(int id)
        {
          return _context.Telefone.Any(e => e.Id == id);
        }
    }
}
