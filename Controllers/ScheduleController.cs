using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrainApp.Data;
using TrainApp.Models;

namespace TrainApp.Controllers
{
    public class ScheduleController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ScheduleController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Schedules
        public async Task<IActionResult> Index()
        {
            var schedules = _context.Schedules.Include(s => s.Train)
                .Include(s => s.OriginStation)
                .Include(s => s.DestinationStation)
                .Include(s => s.Delays);
            return View(await schedules.ToListAsync());
        }

        // GET: Schedules/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var schedule = await _context.Schedules
                .Include(s => s.Train)
                .Include(s => s.OriginStation)
                .Include(s => s.DestinationStation)
                .Include(s => s.Delays)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (schedule == null) return NotFound();

            return View(schedule);
        }

        // GET: Schedules/Create
        public IActionResult Create()
        {
            ViewData["TrainId"] = new SelectList(_context.Trains, "Id", "TrainName");
            ViewData["OriginStationId"] = new SelectList(_context.Stations, "Id", "StationName");
            ViewData["DestinationStationId"] = new SelectList(_context.Stations, "Id", "StationName");
            return View();
        }

        // POST: Schedules/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TrainRouteId,Train,DepartureTime,ArrivalTime,OriginStationId,DestinationStationId,DelayId")] Schedules schedule)
        {
            if (ModelState.IsValid)
            {
                _context.Add(schedule);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(schedule);
        }

        // GET: Schedules/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var schedule = await _context.Schedules.FindAsync(id);
            if (schedule == null) return NotFound();

            ViewData["TrainId"] = new SelectList(_context.Trains, "Id", "TrainName", schedule.TrainRouteId);
            ViewData["OriginStationId"] = new SelectList(_context.Stations, "Id", "StationName", schedule.OriginStationId);
            ViewData["DestinationStationId"] = new SelectList(_context.Stations, "Id", "StationName", schedule.DestinationStationId);
            return View(schedule);
        }

        // POST: Schedules/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TrainRouteId,Train,DepartureTime,ArrivalTime,OriginStationId,DestinationStationId,DelayId")] Schedules schedule)
        {
            if (id != schedule.Id) return NotFound();

            if (ModelState.IsValid)
            {
                _context.Update(schedule);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(schedule);
        }

        // GET: Schedules/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var schedule = await _context.Schedules
                .Include(s => s.Train)
                .Include(s => s.OriginStation)
                .Include(s => s.DestinationStation)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (schedule == null) return NotFound();

            return View(schedule);
        }

        // POST: Schedules/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var schedule = await _context.Schedules.FindAsync(id);
            _context.Schedules.Remove(schedule);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
