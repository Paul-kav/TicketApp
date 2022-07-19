using Microsoft.AspNetCore.Mvc;
using TicketApp.Data;
using TicketApp.Data.Services;

namespace TicketApp.Controllers
{
    public class CinemasController : Controller
    {
        //private readonly AppDbContext _context;
        private readonly ICinemasService _service;
        public CinemasController(ICinemasService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var allCinemas = await _service.GetAllAsync();
            return View(allCinemas);
        }

        //GET: Cinemas/details/1
        public async Task<IActionResult> Details(int id)
        {
            var cinemaDetails = await _service.GetByIdAsync(id);
            if (cinemaDetails == null) return View("NotFound");
            return View(cinemaDetails);
        }

    }
}
