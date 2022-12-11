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
    public class ChatSesijaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ChatSesijaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ChatSesija
        public async Task<IActionResult> Index()
        {
            return View(await _context.ChatSesija.ToListAsync());
        }

        // GET: ChatSesija/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chatSesija = await _context.ChatSesija
                .FirstOrDefaultAsync(m => m.ID == id);
            if (chatSesija == null)
            {
                return NotFound();
            }

            return View(chatSesija);
        }

        // GET: ChatSesija/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ChatSesija/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,NazivGrupe")] ChatSesija chatSesija)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chatSesija);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(chatSesija);
        }

        // GET: ChatSesija/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chatSesija = await _context.ChatSesija.FindAsync(id);
            if (chatSesija == null)
            {
                return NotFound();
            }
            return View(chatSesija);
        }

        // POST: ChatSesija/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,NazivGrupe")] ChatSesija chatSesija)
        {
            if (id != chatSesija.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chatSesija);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChatSesijaExists(chatSesija.ID))
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
            return View(chatSesija);
        }

        // GET: ChatSesija/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chatSesija = await _context.ChatSesija
                .FirstOrDefaultAsync(m => m.ID == id);
            if (chatSesija == null)
            {
                return NotFound();
            }

            return View(chatSesija);
        }

        // POST: ChatSesija/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var chatSesija = await _context.ChatSesija.FindAsync(id);
            _context.ChatSesija.Remove(chatSesija);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChatSesijaExists(int id)
        {
            return _context.ChatSesija.Any(e => e.ID == id);
        }
    }
}
