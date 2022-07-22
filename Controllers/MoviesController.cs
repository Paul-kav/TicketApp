using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using TicketApp.Data;
using TicketApp.Data.Services;

namespace TicketApp.Controllers
{
    public class MoviesController : Controller
    {
        //private readonly AppDbContext _context;
        private readonly IMoviesService _service;
        public MoviesController(IMoviesService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var allMovies = await _service.GetAllAsync(n => n.Cinema);
            return View(allMovies);
        }

        //GET: Movies/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var movieDetails = await _service.GetMovieByIdAsync(id);
            return View(movieDetails);
        }
    }
}
