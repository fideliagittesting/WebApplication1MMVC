﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1MMVC.Models;

namespace WebApplication1MMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Product()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Follow_us()
        {
            return View();

        }

        public IActionResult Program()
        {
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