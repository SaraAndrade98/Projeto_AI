using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projeto_AI.Models;

namespace Projeto_AI.Controllers
{
    public class DispositivoEletronicoController : Controller
    {
        private readonly Projeto_AIContext _context;

        public DispositivoEletronicoController(Projeto_AIContext context)
        {
            _context = context;
        }

        // GET: DispositivoEletronico
        public async Task<IActionResult> Index()
        {
            return View(await _context.DispositivoEletronico.ToListAsync());
        }

        // GET: DispositivoEletronico/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dispositivoEletronico = await _context.DispositivoEletronico
                .FirstOrDefaultAsync(m => m.ID == id);
            if (dispositivoEletronico == null)
            {
                return NotFound();
            }

            return View(dispositivoEletronico);
        }

        // GET: DispositivoEletronico/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DispositivoEletronico/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Ano,Nome,Preco,IncidentesAquaticos,Acessorios")] DispositivoEletronico dispositivoEletronico)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dispositivoEletronico);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dispositivoEletronico);
        }

        // GET: DispositivoEletronico/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dispositivoEletronico = await _context.DispositivoEletronico.FindAsync(id);
            if (dispositivoEletronico == null)
            {
                return NotFound();
            }
            return View(dispositivoEletronico);
        }

        // POST: DispositivoEletronico/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ID,Ano,Nome,Preco,IncidentesAquaticos,Acessorios")] DispositivoEletronico dispositivoEletronico)
        {
            if (id != dispositivoEletronico.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dispositivoEletronico);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DispositivoEletronicoExists(dispositivoEletronico.ID))
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
            return View(dispositivoEletronico);
        }

        // GET: DispositivoEletronico/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dispositivoEletronico = await _context.DispositivoEletronico
                .FirstOrDefaultAsync(m => m.ID == id);
            if (dispositivoEletronico == null)
            {
                return NotFound();
            }

            return View(dispositivoEletronico);
        }

        // POST: DispositivoEletronico/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var dispositivoEletronico = await _context.DispositivoEletronico.FindAsync(id);
            _context.DispositivoEletronico.Remove(dispositivoEletronico);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DispositivoEletronicoExists(string id)
        {
            return _context.DispositivoEletronico.Any(e => e.ID == id);
        }
    }
}
