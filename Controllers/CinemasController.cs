﻿using Microsoft.AspNetCore.Mvc;
using TicketApp.Data;

namespace TicketApp.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDbContext _context;
        public CinemasController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var allCinemas = _context.Cinemas.ToList();
            return View();
        }
    }
}
