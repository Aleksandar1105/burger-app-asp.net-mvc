namespace BurgerApp.App.Controllers
{
using BurgerApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
    public class BurgerController : Controller
    {
        private IBurgerService _burgerService;
        public BurgerController(IBurgerService _burgerService)
        {
            this._burgerService = _burgerService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _burgerService.GetBurgersForCards());
        }
    }
}
