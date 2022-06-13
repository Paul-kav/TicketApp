using Microsoft.AspNetCore.Mvc;
using TicketApp.Data;

namespace TicketApp.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDbContext _context;
        public ProducersController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var allData = _context.Producers.ToList();
            return View();
        }
    }
}
