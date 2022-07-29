using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        //GET: Movies/Create
        public async Task<IActionResult> Create()
        {
            var movieDropdownData = await _service.GetNewMovieDropdownValues();
            ViewBag.Cinemas = new SelectList(movieDropdownData.Cinemas, "Id", "FullName");
            ViewBag.Producers = new SelectList(movieDropdownData.Producers, "Id", "FullName");
            ViewBag.Actors = new SelectList(movieDropdownData.Actors, "Id", "FullName");
            return View();
        }
    }
}
