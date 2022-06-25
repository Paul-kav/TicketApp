using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TicketApp.Data;
using TicketApp.Data.Services;
using TicketApp.Models;

namespace TicketApp.Controllers
{
    public class ActorsController : Controller
    {
        // private readonly AppDbContext _service;
        private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allActors = await _service.GetAllAsync();
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
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null) return View("NotFound");
            return View(actorDetails);
        }

        //Get:Actors/Edit
        public async Task<IActionResult> Edit(int id)
        {
            var actorDetails = await  _service.GetByIdAsync(id);
            if (actorDetails == null) return View("NotFound");
            return View(actorDetails);
            
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName, Biography")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.UpdateAsync(id, actor);

            return RedirectToAction(nameof(Index));
        }
    }
}
