using MathModeling21.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MathModeling21.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MathModelingContext _context;

        public HomeController(ILogger<HomeController> logger, MathModelingContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var events = await _context.Events.ToListAsync();

            if (events.Any())
            {
                var upcomingEvent = events.Where(e => !e.Happening && !e.Ended).OrderBy(e => e.DateStart).FirstOrDefault();

                var happeningEvent = events.Where(e => e.Happening).OrderBy(e => e.DateStart).FirstOrDefault();

                var lastEvent = events.Where(e => e.Ended).OrderByDescending(e => e.DateEnd).FirstOrDefault();

                ViewData["Event"] = happeningEvent ?? (upcomingEvent ?? lastEvent);
            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
