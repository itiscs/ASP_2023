﻿using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FirstApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public  IActionResult Index()
        {
            return View();
        }


        [Route("MyPage")]
        public IActionResult Privacy()
        {
            return View();
        }

        [Route("About2/{id?}")]
        public IActionResult About(string id)
        {
            ViewBag.Pole1 = "Hello world!";
            ViewData["Author"] = id;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}