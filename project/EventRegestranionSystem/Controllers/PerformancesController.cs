using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EventRegestranionSystem.Data;
using EventRegestranionSystem.Models;

namespace EventRegestranionSystem.Controllers
{
    public class PerformancesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PerformancesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Performances
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Performance.Include(p => p.Artist).Include(p => p.Event);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Performances/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Performance == null)
            {
                return NotFound();
            }

            var performance = await _context.Performance
                .Include(p => p.Artist)
                .Include(p => p.Event)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (performance == null)
            {
                return NotFound();
            }

            return View(performance);
        }

        // GET: Performances/Create
        public IActionResult Create()
        {
            ViewData["ArtistId"] = new SelectList(_context.Artist, "Id", "Id");
            ViewData["EventId"] = new SelectList(_context.Event, "Id", "Id");
            return View();
        }

        // POST: Performances/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,QueuePosition,TimeOfStart,ArtistId,EventId")] Performance performance)
        {
            if (ModelState.IsValid)
            {
                _context.Add(performance);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ArtistId"] = new SelectList(_context.Artist, "Id", "Id", performance.ArtistId);
            ViewData["EventId"] = new SelectList(_context.Event, "Id", "Id", performance.EventId);
            return View(performance);
        }

        // GET: Performances/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Performance == null)
            {
                return NotFound();
            }

            var performance = await _context.Performance.FindAsync(id);
            if (performance == null)
            {
                return NotFound();
            }
            ViewData["ArtistId"] = new SelectList(_context.Artist, "Id", "Id", performance.ArtistId);
            ViewData["EventId"] = new SelectList(_context.Event, "Id", "Id", performance.EventId);
            return View(performance);
        }

        // POST: Performances/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,QueuePosition,TimeOfStart,ArtistId,EventId")] Performance performance)
        {
            if (id != performance.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(performance);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PerformanceExists(performance.Id))
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
            ViewData["ArtistId"] = new SelectList(_context.Artist, "Id", "Id", performance.ArtistId);
            ViewData["EventId"] = new SelectList(_context.Event, "Id", "Id", performance.EventId);
            return View(performance);
        }

        // GET: Performances/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Performance == null)
            {
                return NotFound();
            }

            var performance = await _context.Performance
                .Include(p => p.Artist)
                .Include(p => p.Event)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (performance == null)
            {
                return NotFound();
            }

            return View(performance);
        }

        // POST: Performances/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Performance == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Performance'  is null.");
            }
            var performance = await _context.Performance.FindAsync(id);
            if (performance != null)
            {
                _context.Performance.Remove(performance);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PerformanceExists(int id)
        {
          return _context.Performance.Any(e => e.Id == id);
        }
    }
}
