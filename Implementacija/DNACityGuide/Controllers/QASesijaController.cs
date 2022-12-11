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
    public class QASesijaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public QASesijaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: QASesija
        public async Task<IActionResult> Index()
        {
            return View(await _context.QASesija.ToListAsync());
        }

        // GET: QASesija/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qASesija = await _context.QASesija
                .FirstOrDefaultAsync(m => m.ID == id);
            if (qASesija == null)
            {
                return NotFound();
            }

            return View(qASesija);
        }

        // GET: QASesija/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: QASesija/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID")] QASesija qASesija)
        {
            if (ModelState.IsValid)
            {
                _context.Add(qASesija);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(qASesija);
        }

        // GET: QASesija/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qASesija = await _context.QASesija.FindAsync(id);
            if (qASesija == null)
            {
                return NotFound();
            }
            return View(qASesija);
        }

        // POST: QASesija/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID")] QASesija qASesija)
        {
            if (id != qASesija.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(qASesija);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QASesijaExists(qASesija.ID))
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
            return View(qASesija);
        }

        // GET: QASesija/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qASesija = await _context.QASesija
                .FirstOrDefaultAsync(m => m.ID == id);
            if (qASesija == null)
            {
                return NotFound();
            }

            return View(qASesija);
        }

        // POST: QASesija/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var qASesija = await _context.QASesija.FindAsync(id);
            _context.QASesija.Remove(qASesija);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QASesijaExists(int id)
        {
            return _context.QASesija.Any(e => e.ID == id);
        }
    }
}
