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
    public class EntidadesController : Controller
    {
        private readonly PlentyDataContext _context;

        public EntidadesController(PlentyDataContext context)
        {
            _context = context;
        }

        // GET: Entidades
        public async Task<IActionResult> Index()
        {
              return View(await _context.Entidade.ToListAsync());
        }

        // GET: Entidades/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Entidade == null)
            {
                return NotFound();
            }

            var entidade = await _context.Entidade
                .FirstOrDefaultAsync(m => m.Id == id);
            if (entidade == null)
            {
                return NotFound();
            }

            return View(entidade);
        }

        // GET: Entidades/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Entidades/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Tipo,NomeRazaoSocial,NomeFantasia,CNPJCPF,Identidade,InscricaoEstadual,InscricaoMunicipal,Ativo")] Entidade entidade)
        {
            if (ModelState.IsValid)
            {
                _context.Add(entidade);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(entidade);
        }

        // GET: Entidades/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Entidade == null)
            {
                return NotFound();
            }

            var entidade = await _context.Entidade.FindAsync(id);
            if (entidade == null)
            {
                return NotFound();
            }
            return View(entidade);
        }

        // POST: Entidades/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Tipo,NomeRazaoSocial,NomeFantasia,CNPJCPF,Identidade,InscricaoEstadual,InscricaoMunicipal,Ativo")] Entidade entidade)
        {
            if (id != entidade.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(entidade);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EntidadeExists(entidade.Id))
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
            return View(entidade);
        }

        // GET: Entidades/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Entidade == null)
            {
                return NotFound();
            }

            var entidade = await _context.Entidade
                .FirstOrDefaultAsync(m => m.Id == id);
            if (entidade == null)
            {
                return NotFound();
            }

            return View(entidade);
        }

        // POST: Entidades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Entidade == null)
            {
                return Problem("Entity set 'PlentyDataContext.Entidade'  is null.");
            }
            var entidade = await _context.Entidade.FindAsync(id);
            if (entidade != null)
            {
                _context.Entidade.Remove(entidade);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EntidadeExists(int id)
        {
          return _context.Entidade.Any(e => e.Id == id);
        }
    }
}
