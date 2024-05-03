using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SistControleVendas.Data;
using SistControleVendas.Models;

namespace SistControleVendas.Controllers
{
    public class FormaPagtosController : Controller
    {
        private readonly ControleVendasContext _context;

        public FormaPagtosController(ControleVendasContext context)
        {
            _context = context;
        }

        // GET: FormaPagtos
        public async Task<IActionResult> Index()
        {
            return View(await _context.FormaPagto.ToListAsync());
        }

        // GET: FormaPagtos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formaPagto = await _context.FormaPagto
                .FirstOrDefaultAsync(m => m.FormaPagtoID == id);
            if (formaPagto == null)
            {
                return NotFound();
            }

            return View(formaPagto);
        }

        // GET: FormaPagtos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FormaPagtos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FormaPagtoID,CartaoCred,CartaoDeb,Pix")] FormaPagto formaPagto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(formaPagto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(formaPagto);
        }

        // GET: FormaPagtos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formaPagto = await _context.FormaPagto.FindAsync(id);
            if (formaPagto == null)
            {
                return NotFound();
            }
            return View(formaPagto);
        }

        // POST: FormaPagtos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FormaPagtoID,CartaoCred,CartaoDeb,Pix")] FormaPagto formaPagto)
        {
            if (id != formaPagto.FormaPagtoID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(formaPagto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FormaPagtoExists(formaPagto.FormaPagtoID))
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
            return View(formaPagto);
        }

        // GET: FormaPagtos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formaPagto = await _context.FormaPagto
                .FirstOrDefaultAsync(m => m.FormaPagtoID == id);
            if (formaPagto == null)
            {
                return NotFound();
            }

            return View(formaPagto);
        }

        // POST: FormaPagtos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var formaPagto = await _context.FormaPagto.FindAsync(id);
            if (formaPagto != null)
            {
                _context.FormaPagto.Remove(formaPagto);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FormaPagtoExists(int id)
        {
            return _context.FormaPagto.Any(e => e.FormaPagtoID == id);
        }
    }
}
