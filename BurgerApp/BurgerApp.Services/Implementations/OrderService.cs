using BurgerApp.DataAccess.Repositories.Interfaces;
using BurgerApp.Domain.Models;
using BurgerApp.Services.Interfaces;
using BurgerApp.ViewModels.OrderViewModels;
using BurgerApp.Mappers;
using BurgerApp.DataAccess.Repositories.Implementations;

namespace BurgerApp.Services.Implementations
{
    public class OrderService : IOrderService
    {
        private IRepository<Order> _orderRepository;
        public OrderService(IRepository<Order> orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public void Delete(int id)
        {
            var existingOrder = _orderRepository.GetById(id);

            if (existingOrder == null)
            {
                throw new Exception($"Order with id {id} does not exist");
            }

            _orderRepository.DeleteById(existingOrder.Id);
        }

        public async Task<OrderViewModel> Details(int id)
        {
            var order = await _orderRepository.GetById(id);

            if (order == null)
            {
                throw new Exception("Order not found");
            }

            return order.ToViewModel();
        }

        public async Task<List<OrderViewModel>> GetAll()
        {
            List<Order> ordersDb = await _orderRepository.GetAll();

            return ordersDb.Select(x => x.ToViewModel()).ToList();
        }

        public async Task<int> Save(OrderViewModel model)
        {
            var order = new Order()
            {
               
            };

            await _orderRepository.Insert(order);

            return order.Id;
        }
    }
}
