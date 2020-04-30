using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using WebApplication2.ViewModels;

namespace WebApplication2.Controllers
{
    public class GoogleMapsController : Controller
    {
        private readonly IGoogleMapsRepository
            _googleMapsRepository;
        //private readonly Google_mapsContext _context;

        public GoogleMapsController(
            IGoogleMapsRepository googleMapsRepository)
        {
            _googleMapsRepository = googleMapsRepository;
        }

        // GET: GoogleMaps
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create
            (GoogleMapsCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var newEmployee = new GoogleMap
                {
                    Address = model.Address,
                    Lat = model.Lat,
                    Long = model.Long
                };
                _googleMapsRepository.Add(newEmployee);

                return RedirectToAction("Index",
                    "GoogleMaps");
            }

            return View();
        }

/*        // GET: GoogleMaps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var googleMap = await _context.GoogleMap
                .FirstOrDefaultAsync(m => m.Id == id);
            if (googleMap == null)
            {
                return NotFound();
            }

            return View(googleMap);
        }

        // GET: GoogleMaps/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GoogleMaps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Rating,Address,Lat,Long")] GoogleMap googleMap)
        {
            if (ModelState.IsValid)
            {
                _context.Add(googleMap);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(googleMap);
        }

        // GET: GoogleMaps/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var googleMap = await _context.GoogleMap.FindAsync(id);
            if (googleMap == null)
            {
                return NotFound();
            }
            return View(googleMap);
        }

        // POST: GoogleMaps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Rating,Address,Lat,Long")] GoogleMap googleMap)
        {
            if (id != googleMap.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(googleMap);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GoogleMapExists(googleMap.Id))
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
            return View(googleMap);
        }

        // GET: GoogleMaps/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var googleMap = await _context.GoogleMap
                .FirstOrDefaultAsync(m => m.Id == id);
            if (googleMap == null)
            {
                return NotFound();
            }

            return View(googleMap);
        }

        // POST: GoogleMaps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var googleMap = await _context.GoogleMap.FindAsync(id);
            _context.GoogleMap.Remove(googleMap);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GoogleMapExists(int id)
        {
            return _context.GoogleMap.Any(e => e.Id == id);
        }*/

        public JsonResult GetAllLocation()
        {
            var data =
                _googleMapsRepository.GetAllLocations();
            return Json(data);
        }
    }

    
}