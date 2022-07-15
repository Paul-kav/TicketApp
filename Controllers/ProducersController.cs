﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TicketApp.Data;
using TicketApp.Data.Services;
using TicketApp.Models;

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

        //GET: producers/create
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName, Description")] Producer producer)
        {
            if (!ModelState.IsValid)
            {
                return View(producer);
            }
            await _service.AddAsync(producer);

            return RedirectToAction(nameof(Index));
        }

        //GET: producers/edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null) return View("NotFound");
            return View(producerDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("FullName,Id, Description")] Producer producer)
        {
            if (!ModelState.IsValid)
            {
                return View(producer);
            }
            if(id == producer.Id)
            {
                await _service.UpdateAsync(id, producer);
                return RedirectToAction(nameof(Index));
            }
            return View(producer);
           

            
        }
    }
}
