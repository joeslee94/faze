using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FAZE.Data;
using FAZE.Models;

namespace FAZE.Controllers
{
    public class FishingTripController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FishingTripController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: FishingTrip
        public async Task<IActionResult> Index()
        {
            return View(await _context.FishingTrip.ToListAsync());
        }

        // GET: FishingTrip/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fishingTrip = await _context.FishingTrip
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fishingTrip == null)
            {
                return NotFound();
            }

            return View(fishingTrip);
        }

        // GET: FishingTrip/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FishingTrip/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Location,Date,StartTime,TimeSpentFishing,TotalFishCaught,NumOfBites,NumOfBaitUsed,Season,AvgTemp,WeatherConditions,MoonPhase,Tide,Comments")] FishingTrip fishingTrip)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fishingTrip);
                await _context.SaveChangesAsync();
                RedirectToAction(nameof(Index));
            }
            return View(fishingTrip);
        }

        // GET: FishingTrip/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fishingTrip = await _context.FishingTrip.FindAsync(id);
            if (fishingTrip == null)
            {
                return NotFound();
            }
            return View(fishingTrip);
        }

        // POST: FishingTrip/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Location,Date,StartTime,TimeSpentFishing,TotalFishCaught,NumOfBites,NumOfBaitUsed,Season,AvgTemp,WeatherConditions,MoonPhase,Tide,Comments")] FishingTrip fishingTrip)
        {
            if (id != fishingTrip.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fishingTrip);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FishingTripExists(fishingTrip.Id))
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
            return View(fishingTrip);
        }

        // GET: FishingTrip/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fishingTrip = await _context.FishingTrip
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fishingTrip == null)
            {
                return NotFound();
            }

            return View(fishingTrip);
        }

        // POST: FishingTrip/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fishingTrip = await _context.FishingTrip.FindAsync(id);
            _context.FishingTrip.Remove(fishingTrip);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FishingTripExists(int id)
        {
            return _context.FishingTrip.Any(e => e.Id == id);
        }
    }
}
