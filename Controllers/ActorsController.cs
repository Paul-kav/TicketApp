using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TicketApp.Data;

namespace TicketApp.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext _service;

        public ActorsController(AppDbContext service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allActors = await _service.Actors.ToListAsync();
            return View(allActors);
        }

        public async Task<IActionResult> Create()
        {
            var allActors = await _service.Actors.ToListAsync();
            return View(allActors);
        }
            
    }
}
