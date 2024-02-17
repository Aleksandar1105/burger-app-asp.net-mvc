using BurgerApp.Services.Interfaces;
using BurgerApp.ViewModels.OrderViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BurgerApp.App.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task<IActionResult> Index()
        {
            var orders = await _orderService.GetAll();
            return View(orders);
        }

        public async Task<IActionResult> Details(int id)
        {
            var order = await _orderService.Details(id);
            return View(order);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(OrderViewModel model)
        {
            await _orderService.Save(model);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int id)
        {
            var order = await _orderService.Details(id);
            return View(order);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(OrderViewModel model)
        {
            await _orderService.Save(model);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
             _orderService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
