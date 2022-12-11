using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DNACityGuide.Data;
using DNACityGuide.Models;

namespace DNACityGuide.Controllers
{
    public class RezervacijaTuraController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RezervacijaTuraController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: RezervacijaTura
        public async Task<IActionResult> Index()
        {
            return View(await _context.RezervacijaTura.ToListAsync());
        }

        // GET: RezervacijaTura/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rezervacijaTura = await _context.RezervacijaTura
                .FirstOrDefaultAsync(m => m.ID == id);
            if (rezervacijaTura == null)
            {
                return NotFound();
            }

            return View(rezervacijaTura);
        }

        // GET: RezervacijaTura/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RezervacijaTura/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,KorisnikID")] RezervacijaTura rezervacijaTura)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rezervacijaTura);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rezervacijaTura);
        }

        // GET: RezervacijaTura/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rezervacijaTura = await _context.RezervacijaTura.FindAsync(id);
            if (rezervacijaTura == null)
            {
                return NotFound();
            }
            return View(rezervacijaTura);
        }

        // POST: RezervacijaTura/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,KorisnikID")] RezervacijaTura rezervacijaTura)
        {
            if (id != rezervacijaTura.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rezervacijaTura);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RezervacijaTuraExists(rezervacijaTura.ID))
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
            return View(rezervacijaTura);
        }

        // GET: RezervacijaTura/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rezervacijaTura = await _context.RezervacijaTura
                .FirstOrDefaultAsync(m => m.ID == id);
            if (rezervacijaTura == null)
            {
                return NotFound();
            }

            return View(rezervacijaTura);
        }

        // POST: RezervacijaTura/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rezervacijaTura = await _context.RezervacijaTura.FindAsync(id);
            _context.RezervacijaTura.Remove(rezervacijaTura);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RezervacijaTuraExists(int id)
        {
            return _context.RezervacijaTura.Any(e => e.ID == id);
        }
    }
}
