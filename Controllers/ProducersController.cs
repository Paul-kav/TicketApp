using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TicketApp.Data;
using TicketApp.Data.Services;

namespace TicketApp.Controllers
{
    public class ProducersController : Controller
    {
        //inject the appdbcontext
        // private readonly AppDbContext _context;

        //inject the services
        private readonly IProducersService _service;
        public ProducersController(IProducersService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var allProducers = await _service.GetAllAsync();
            return View(allProducers);
        }

        //GET: producers/details/1
        public async Task<IActionResult> Details(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if(producerDetails == null) return View("NotFound");
            return View(producerDetails);
        }


    }
}
