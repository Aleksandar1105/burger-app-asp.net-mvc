﻿namespace BurgerApp.App.Controllers
{
    using BurgerApp.Services.Interfaces;
    using BurgerApp.ViewModels.BurgerViewModels;
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

        public async Task<IActionResult> Details(int id)
        {
            return View(await _burgerService.GetBurgerDetails(id));
        }

        public async Task<IActionResult> Delete(int id)
        {
            return View(await _burgerService.DeleteBurgerById(id));
        }

        public IActionResult Create()
        {
            BurgerViewModel burgerViewModel = new();

            return View(burgerViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(BurgerViewModel burgerViewModel)
        {
            if(ModelState.IsValid)
            {
                if (string.IsNullOrWhiteSpace(burgerViewModel.Name) || burgerViewModel.Price == 0 || string.IsNullOrWhiteSpace(burgerViewModel.ImageUrl))
                {
                    ModelState.AddModelError("", "You must enter the price and the image url!");
                    return View(burgerViewModel);
                }

            await _burgerService.CreateBurger(burgerViewModel);
            return RedirectToAction("Index");
            }

            return View(burgerViewModel);

        }

        public async Task<IActionResult> Edit(int id)
        {
            BurgerViewModel burgerViewModel = await _burgerService.GetBurgerForEditing(id);

            return View(burgerViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(BurgerViewModel burgerViewModel)
        {
            await _burgerService.EditBurger(burgerViewModel);
            return RedirectToAction("Index");
        }
    }
}
