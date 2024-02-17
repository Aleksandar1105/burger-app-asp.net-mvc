using BurgerApp.Domain.Models;
using BurgerApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BurgerApp.App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBurgerService _burgerService;

        public HomeController(ILogger<HomeController> logger, IBurgerService burgerService)
        {
            _logger = logger;
            _burgerService = burgerService;
        }

        public async Task<IActionResult> Index()
        {
            var mostPopularBurger = await _burgerService.GetMostPopularBurger();
            ViewData["MostPopularBurger"] = mostPopularBurger;

            return View(await _burgerService.GetBurgersForCards());
        }

        public IActionResult AboutUs()
        {
            return View();
        }
    }
}