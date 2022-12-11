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
    public class KatalogSuveniraController : Controller
    {
        private readonly ApplicationDbContext _context;

        public KatalogSuveniraController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: KatalogSuvenira
        public async Task<IActionResult> Index()
        {
            return View(await _context.KatalogSuvenira.ToListAsync());
        }

        // GET: KatalogSuvenira/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var katalogSuvenira = await _context.KatalogSuvenira
                .FirstOrDefaultAsync(m => m.ID == id);
            if (katalogSuvenira == null)
            {
                return NotFound();
            }

            return View(katalogSuvenira);
        }

        // GET: KatalogSuvenira/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: KatalogSuvenira/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID")] KatalogSuvenira katalogSuvenira)
        {
            if (ModelState.IsValid)
            {
                _context.Add(katalogSuvenira);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(katalogSuvenira);
        }

        // GET: KatalogSuvenira/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var katalogSuvenira = await _context.KatalogSuvenira.FindAsync(id);
            if (katalogSuvenira == null)
            {
                return NotFound();
            }
            return View(katalogSuvenira);
        }

        // POST: KatalogSuvenira/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID")] KatalogSuvenira katalogSuvenira)
        {
            if (id != katalogSuvenira.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(katalogSuvenira);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KatalogSuveniraExists(katalogSuvenira.ID))
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
            return View(katalogSuvenira);
        }

        // GET: KatalogSuvenira/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var katalogSuvenira = await _context.KatalogSuvenira
                .FirstOrDefaultAsync(m => m.ID == id);
            if (katalogSuvenira == null)
            {
                return NotFound();
            }

            return View(katalogSuvenira);
        }

        // POST: KatalogSuvenira/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var katalogSuvenira = await _context.KatalogSuvenira.FindAsync(id);
            _context.KatalogSuvenira.Remove(katalogSuvenira);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KatalogSuveniraExists(int id)
        {
            return _context.KatalogSuvenira.Any(e => e.ID == id);
        }
    }
}
