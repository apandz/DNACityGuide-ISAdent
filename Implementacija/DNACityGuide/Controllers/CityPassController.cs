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
    public class CityPassController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CityPassController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CityPass
        public async Task<IActionResult> Index()
        {
            return View(await _context.CityPass.ToListAsync());
        }

        // GET: CityPass/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cityPass = await _context.CityPass
                .FirstOrDefaultAsync(m => m.ID == id);
            if (cityPass == null)
            {
                return NotFound();
            }

            return View(cityPass);
        }

        // GET: CityPass/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CityPass/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,KorisnikID")] CityPass cityPass)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cityPass);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cityPass);
        }

        // GET: CityPass/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cityPass = await _context.CityPass.FindAsync(id);
            if (cityPass == null)
            {
                return NotFound();
            }
            return View(cityPass);
        }

        // POST: CityPass/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,KorisnikID")] CityPass cityPass)
        {
            if (id != cityPass.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cityPass);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CityPassExists(cityPass.ID))
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
            return View(cityPass);
        }

        // GET: CityPass/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cityPass = await _context.CityPass
                .FirstOrDefaultAsync(m => m.ID == id);
            if (cityPass == null)
            {
                return NotFound();
            }

            return View(cityPass);
        }

        // POST: CityPass/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cityPass = await _context.CityPass.FindAsync(id);
            _context.CityPass.Remove(cityPass);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CityPassExists(int id)
        {
            return _context.CityPass.Any(e => e.ID == id);
        }
    }
}
