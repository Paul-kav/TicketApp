using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TicketApp.Data;
using TicketApp.Models;

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
        //Get:Actors/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName, Biography")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.AddAsync(actor);

            return RedirectToAction(nameof(Index));
        }

        //Get:Actors/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await _service.GetByIdAsync(int id);
            if (actorDetails == null) return View("Not Found");
            return View(actorDetails);
        }
    }
}
