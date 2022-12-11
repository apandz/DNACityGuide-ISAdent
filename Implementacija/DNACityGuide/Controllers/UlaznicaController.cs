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
    public class UlaznicaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UlaznicaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Ulaznica
        public async Task<IActionResult> Index()
        {
            return View(await _context.Ulaznica.ToListAsync());
        }

        // GET: Ulaznica/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ulaznica = await _context.Ulaznica
                .FirstOrDefaultAsync(m => m.ID == id);
            if (ulaznica == null)
            {
                return NotFound();
            }

            return View(ulaznica);
        }

        // GET: Ulaznica/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ulaznica/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,NazivAtrakcije,Cijena,Popust,DostupnaKolicina,KupacID")] Ulaznica ulaznica)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ulaznica);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ulaznica);
        }

        // GET: Ulaznica/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ulaznica = await _context.Ulaznica.FindAsync(id);
            if (ulaznica == null)
            {
                return NotFound();
            }
            return View(ulaznica);
        }

        // POST: Ulaznica/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,NazivAtrakcije,Cijena,Popust,DostupnaKolicina,KupacID")] Ulaznica ulaznica)
        {
            if (id != ulaznica.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ulaznica);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UlaznicaExists(ulaznica.ID))
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
            return View(ulaznica);
        }

        // GET: Ulaznica/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ulaznica = await _context.Ulaznica
                .FirstOrDefaultAsync(m => m.ID == id);
            if (ulaznica == null)
            {
                return NotFound();
            }

            return View(ulaznica);
        }

        // POST: Ulaznica/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ulaznica = await _context.Ulaznica.FindAsync(id);
            _context.Ulaznica.Remove(ulaznica);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UlaznicaExists(int id)
        {
            return _context.Ulaznica.Any(e => e.ID == id);
        }
    }
}
